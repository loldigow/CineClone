using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace PacoteExtra.ViewModels
{
    [ObservableObject]
    internal partial class MeusIngressosViewModel : BaseViewModel
    {
        [RelayCommand]
        async void Voltar()
        {
           await App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
