using CinemaCore.Core.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PacoteExtra.Componentes;
using PacoteExtra.Core.Services;
using PacoteExtra.Core.Util;
using PacoteExtra.Views.BuscaShopping;
using PacoteExtra.Views.MeusIngressos;
using PacoteExtra.Views.ProgrtamacaoDeFilme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;

namespace PacoteExtra.ViewModels
{
    [ObservableObject]
    partial class InicioMVVM : BaseViewModel
    {
        #region Servicos
        private readonly FilmeService _filmeService = new FilmeService();
        private readonly ShoppingService _filialService = new ShoppingService();
        private readonly ProgramacaoService _sessaoService = new ProgramacaoService();
        private readonly IngressosService _historicoIngressos = new IngressosService();
        private readonly CuponsDescontoService _descontoService = new CuponsDescontoService();

        #endregion

        [ObservableProperty]
        int pageSelected;
        [ObservableProperty]
        bool page1Visible;
        [ObservableProperty]
        bool page2Visible;
        [ObservableProperty]
        bool page3Visible;
        [ObservableProperty]
        bool page4Visible;
        [ObservableProperty]
        FilialCinemaModel filialSelecionada;

        [ObservableProperty]
        List<CollectionViewModel> compras;
        [ObservableProperty]
        List<CollectionViewModel> filmeList;
        [ObservableProperty]
        List<CollectionViewModel> favoritosList;
        [ObservableProperty]
        List<CollectionViewModel> ingressos;
        [ObservableProperty]
        List<CollectionViewModel> cuponsList;

        [ObservableProperty]
        List<ProgramacaoModel> programacao;

        [RelayCommand]
        public void CuponsClick()
        {
            PageSelected = 3;
            OnTabChanged(3);
        }
        [RelayCommand]
        public async void PesquisaShopping()
        {
            await App.Current.MainPage.Navigation.PushAsync(new BuscaShoppingPage());
        }

        [RelayCommand]
        void ProgramacaoCompletaClick()
        {

        }

        [RelayCommand]
        public async void MinhasComprasClick()
        {
            await App.Current.MainPage.Navigation.PushAsync(new MeusIngressosPage());
        }

        [RelayCommand]
        async void CartazClick(object filme)
        {
            SingletonParametros.GetInstance().AdicioneParametros(nameof(ProgramacaoFilme), filme);
            await App.Current.MainPage.Navigation.PushAsync(new ProgramacaoFilme());
        }

        public InicioMVVM()
        {
            page1Visible = true;
            PageSelected = 1;
        }

        private void CarregueFilialFavorita()
        {

        }

        public async override void EventoAoAparecer()
        {

            await Carregando.CarregueEnquandoAcaoEstiverRodando(async () =>
            {

                var filial = await _filialService.ObtenhaUltimaFiliaBuscada();
                var listaFilmes = await _filmeService.ObtenhaBilheteriaDeFilmesPorFilial(filial.Codigo);
                var listaDefavoritos = await _filmeService.ObtenhaBilheteriesAdicionadasAoFavoritoAsync();
                var programacaoDestaFilial = await _sessaoService.ObtenhaSessoesDaFilial(filial.Codigo, DateTime.Now, DateTime.Now.AddDays(15));
                var ultimasCompras = await _historicoIngressos.ObtenhaUltimosIngressosDaFilial(filial.Codigo);
                var cupons = await _descontoService.ObtenhaDescontosDaFilial(filial.Codigo);

                var favoritos = from favorito in listaDefavoritos
                                join filme in listaFilmes
                            on favorito.CodigoFilme equals filme.Codigo
                                select filme;

                Device.BeginInvokeOnMainThread(() =>
                {
                    FilmeList = listaFilmes.Select(x => new CollectionViewModel()
                    {
                        Id = x.Codigo,
                        Descricao = x.UrlImagem
                    }).ToList();
                    FavoritosList = favoritos.Select(x => new CollectionViewModel()
                    {
                        Id = x.Codigo,
                        Descricao = x.UrlImagem
                    }).ToList();
                    FilialSelecionada = filial;
                    Programacao = programacaoDestaFilial;
                    Ingressos = ultimasCompras.Select(x => new CollectionViewModel() 
                    { 
                        Id = x.Codigo, 
                        Titulo = x.Filme.NomeFilme, 
                        Descricao = x.Sessao.DescricaoSessao, 
                        Descricao1 = x.Sessao.DataSessao.ToString("HH:mm"),
                        Descricao2 = string.Join(", ", x.Poltronas.Select(x => x.Descricao)), 
                        Descricao3 = x.Sessao.DataSessao.ToString("dd/MM/YYYY"), 
                        Descricao4 = x.FilialCinema.Descricao 
                    }).ToList();

                    CuponsList = cupons.Select(x => new CollectionViewModel() { }).ToList();
                });
            }, "Carregando dados");
        }

        [RelayCommand]
        public void OnTabChanged(object objeto)
        {
            var tabIndex = (int)objeto;
            List<string> tabs = new List<string>()
            {
                nameof(Page1Visible),
                nameof(Page2Visible),
                nameof(Page3Visible),
                nameof(Page4Visible),
            };
            for (int i = 0; i < tabs.Count; i++)
            {
                var este = typeof(InicioMVVM);
                PropertyInfo piInstance = este.GetProperty(tabs.ElementAt(i));
                piInstance.SetValue(this, i + 1 == tabIndex);
            }

        }
    }
}
