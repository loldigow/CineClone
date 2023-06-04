using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace PacoteExtra.Componentes.ExemplosDeUso.DateTimeLineSwipe
{
    public partial class DateSwipeViewModel : ObservableObject
    {
        [ObservableProperty]
        DateTime inicio;

        [ObservableProperty]
        DateTime fim;

        [RelayCommand]
        void SelecioneiDia(object objeto)
        {

        }

        public DateSwipeViewModel()
        {
            Inicio = DateTime.Now;
            Fim = DateTime.Now.AddDays(15);
        }
    }
}
