using PacoteExtra.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PacoteExtra.Views
{
    public class BasePages : ContentPage
    {
        public double Width = App.WidthApp;
        public double HeightApp = App.HeightApp;
        public BaseViewModel _viewModel => (BaseViewModel)this.BindingContext;
        protected override void OnAppearing()
        {
            BackgroundColor = (Color)Application.Current.Resources["CorBackgroundSecundario"];
            base.OnAppearing();
            if (_viewModel != null)
                _viewModel.EventoAoAparecer();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (_viewModel != null)
                _viewModel.EventoAoDesaparecer();
        }
        protected override bool OnBackButtonPressed()
        {
            if (_viewModel != null)
            {
                return _viewModel.EventoNoClickBotaoVoltar();
            }
            return base.OnBackButtonPressed();
        }
    }
}
