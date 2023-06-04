using CommunityToolkit.Mvvm.ComponentModel;
using PacoteExtra.Componentes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PacoteExtra.ViewModels
{
    [ObservableObject]
    public partial class BuscaShoppingViewModel : BaseViewModel
    {
        [ObservableProperty]
        public List<CollectionViewModel> shoppings;

        public BuscaShoppingViewModel()
        {
            Task.Run(() =>
            {
                CarregueListaDeShoppings();
            });
        }

        private void CarregueListaDeShoppings()
        {
            var shoppings = new List<CollectionViewModel>();
            shoppings.Add(new CollectionViewModel
            {
                Titulo = "Cineflix aparecida de goiânia",
                Descricao = "2,94 KM",
                Descricao1 = "Av. Independencia",
                Descricao2 = "Aparecida de goiania - Go"
            });
            shoppings.Add(new CollectionViewModel
            {
                Titulo = "Cineflix Shopping Sul - Valparaiso",
                Descricao = "2,94 KM",
                Descricao1 = "Rod BR 040",
                Descricao2 = "Valparaíso de Goias - Go"
            });
            Device.BeginInvokeOnMainThread(() => {
                Shoppings= shoppings;
            });
        }
    }
}
