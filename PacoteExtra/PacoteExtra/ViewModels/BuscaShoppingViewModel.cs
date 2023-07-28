using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PacoteExtra.Componentes;
using PacoteExtra.Core.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PacoteExtra.ViewModels
{
    [ObservableObject]
    public partial class BuscaShoppingViewModel : BaseViewModel
    {
        private readonly ShoppingService _filialService = new ShoppingService();



        [ObservableProperty]
        private List<CollectionViewModel> filialCinema;

        [RelayCommand]
        public async void SelecionouShopping(object shopping)
        {
            if (shopping is CollectionViewModel model)
            {
                _filialService.MarqueSelecaoDeFilial(model.Id);
                await App.Current.MainPage.Navigation.PopAsync();
            }
        }

        public BuscaShoppingViewModel()
        {
            Task.Run(() =>
            {
                
            });
        }

        public override async void EventoAoAparecer()
        {
            base.EventoAoAparecer();
            await Carregando.CarregueEnquandoAcaoEstiverRodando(async () =>
            {
                await PesquisaShopping(string.Empty);
            }, "Carregando lista");
        }

        [RelayCommand]
        public async Task PesquisaShopping(object texto)
        {
            var textoSelecionado = (string)texto;
            var listaFiltrada = (await _filialService.ObtenhaPorDescricaoAsync(textoSelecionado)).Select(x => new CollectionViewModel
            {
                Id = x.Codigo,
                Titulo = x.Descricao,
                Descricao = $"{x.Distancia} KM",
                Descricao1 = x.Endereco,
                Descricao2 = $"{x.Endereco} - {x.Estado}"
            }).ToList();

            var ultimoSelecionado = await _filialService.ObtenhaUltimaFiliaBuscada();
            listaFiltrada.ForEach(x => { x.PropriedadeBoleana = x.Id == ultimoSelecionado.Codigo; });

            Device.BeginInvokeOnMainThread(() =>
            {
                FilialCinema = listaFiltrada;
            });

        }

        [RelayCommand]
        public void Voltar()
        {
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
