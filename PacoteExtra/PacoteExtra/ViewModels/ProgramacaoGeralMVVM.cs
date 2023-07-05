using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PacoteExtra.Componentes;
using PacoteExtra.Views.BuscaShopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PacoteExtra.ViewModels
{
    [ObservableObject]
    public partial class ProgramacaoGeralMVVM : BaseViewModel
    {
        public ProgramacaoGeralMVVM()
        {
            CarregueFilmes();
        }

        private void CarregueFilmes()
        {
            

        }

        [RelayCommand]
        public void ProgramacaoCompletaClick()
        {

        }

        [RelayCommand]
        public async void PesquisaShopping()
        {
            await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new BuscaShoppingPage()));
        }

        [RelayCommand]
        public void FilmeClik(object filmeSelecionado)
        {

        }
    }
}
