using CinemaCore.Core.Model;
using CinemaCore.Core.Servico;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PacoteExtra.Componentes;
using PacoteExtra.Views.BuscaShopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PacoteExtra.ViewModels
{
    [ObservableObject]
    partial class InicioMVVM : BaseViewModel
    {
        #region Servicos
        private readonly FilmeService _filmeService = new FilmeService();
        private readonly ShoppingService _filialService = new ShoppingService();
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
        List<CollectionViewModel> filmeList;
        [ObservableProperty]
        List<CollectionViewModel> favoritosList;

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
        async void CartazClick(object filme)
        {
            if (filme is CollectionViewModel cartazSelecionado)
            {


                PageSelected = 2;

            }

        }



        public InicioMVVM()
        {
            page1Visible = true;
            PageSelected = 1;
            Task.Run(async () =>
            {


            });
        }

        private void CarregueFilialFavorita()
        {
            throw new NotImplementedException();
        }

        public async override void EventoAoAparecer()
        {
            await Task.Run(() =>
            {
                var filial = _filialService.ObtenhaUltimaFiliaBuscada();
                var listaFilmes = _filmeService.ObtenhaBilheteriaDeFilmes();
                var listaDefavoritos = _filmeService.ObtenhaBilheteriesAdicionadasAoFavorito();
                Device.BeginInvokeOnMainThread(() =>
                {
                    FilmeList = listaFilmes.Select(x => new CollectionViewModel()
                    {
                        Id = x.Codigo,
                        Descricao = x.UrlImagem
                    }).ToList();
                    FavoritosList = listaDefavoritos.Select(x => new CollectionViewModel()
                    {
                        Id = x.Codigo,
                        Descricao = x.UrlImagem
                    }).ToList();
                });


                Device.BeginInvokeOnMainThread(() =>
                {
                    FilialSelecionada = filial;
                });
            });
        }

        private void CrieDadosfake()
        {

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
