using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PacoteExtra.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PacoteExtra.Componentes.ExemplosDeUso.Poltrona
{
    [ObservableObject]
    internal partial class PoltronaMVVM : BaseViewModel
    {
        [RelayCommand]
        private void PoltronaClick(object poltrona)
        {

        }
    }
}
