using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PacoteExtra.Componentes;
using PacoteExtra.Views.BuscaShopping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PacoteExtra.ViewModels
{
    [ObservableObject]
    partial class InicioMVVM : BaseViewModel
    {
        [ObservableProperty]
        GridLength tamanhoFrameIngressos;

        [ObservableProperty]
        GridLength tamanhoFrameFavoritos;

        [ObservableProperty]
        List<CollectionViewModel> filmes;

        [ObservableProperty]
        List<CollectionViewModel> favoritos;

        [ObservableProperty]
        public bool page1Visible;

        [ObservableProperty]
        public bool page2Visible;

        [ObservableProperty]
        public bool page3Visible;

        [ObservableProperty]
        public bool page4Visible;




        [RelayCommand]
        void PesquisarShopping()
        {
            var searchShoppingPage = new BuscaShoppingPage();
            App.Current.MainPage.Navigation.PushAsync(searchShoppingPage);
        }

        [RelayCommand]
        void CuponsClick(object objeto)
        {

        }

        [RelayCommand]
        void ProgramacaoCompletaClick()
        {

        }

        [RelayCommand]
        void FilmeClik(object filme)
        {

        }

        public InicioMVVM()
        {
            Filmes = new List<CollectionViewModel>();
            Favoritos =  new List<CollectionViewModel>();
            page1Visible = true;
        }
        public async override void EventoAoAparecer()
        {
            await Task.Run(() =>
            {
                var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
                CrieDadosfake();
            });
        }

        private void CrieDadosfake()
        {
            
        }

        partial void OnFavoritosChanged(List<CollectionViewModel> value)
        {
           // TamanhoFrameFavoritos = ExtraiaGridTamanho(Favoritos.Count());
        }

        [RelayCommand]
        public void Guia1Toque()
        {
            Page1Visible = true;
            Page2Visible = false;
            Page3Visible = false;
            Page4Visible = false;

        }

        [RelayCommand]
        public void Guia2Toque()
        {
            Page1Visible = false;
            Page2Visible = true;
            Page3Visible = false;
            Page4Visible = false;
        }

        [RelayCommand]
        public void Guia3Toque()
        {
            Page1Visible = false;
            Page2Visible = false;
            Page3Visible = true;
            Page4Visible = false;
        }

        [RelayCommand]
        public void Guia4Toque()
        {
            Page1Visible = false;
            Page2Visible = false;
            Page3Visible = false;
            Page4Visible = true;
        }


        partial void OnFilmesChanged(List<CollectionViewModel> value)
        {
            
        }
    }

    public class FilmeModel
    {
        public int Id { get; set; }
        public string Imagem { get; set; }
    }

}
