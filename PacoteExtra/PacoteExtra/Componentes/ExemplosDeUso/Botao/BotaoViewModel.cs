using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PacoteExtra.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PacoteExtra.Componentes.ExemplosDeUso.Botao
{    partial class BotaoViewModel : ObservableObject
    {
        [ObservableProperty]
        string umTexto;

        [RelayCommand]
        void Iniciar()
        {

        }
        public BotaoViewModel()
        {
            UmTexto = "Aperte este Botão";
        }
    }
}
