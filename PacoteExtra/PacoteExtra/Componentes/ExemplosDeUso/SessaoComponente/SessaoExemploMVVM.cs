using CommunityToolkit.Mvvm.ComponentModel;
using PacoteExtra.Models;
using PacoteExtra.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PacoteExtra.Componentes.ExemplosDeUso.SessaoComponente
{
    [ObservableObject]
    internal partial class SessaoExemploMVVM :BaseViewModel
    {
        [ObservableProperty]
        private List<PoltronaAppModel> poltronas;
        [ObservableProperty]
        private int tamanhoSessaoEmX;
        [ObservableProperty]
        private int tamanhoSessaoEmY;
        public SessaoExemploMVVM() {
            TamanhoSessaoEmX = 10;
            TamanhoSessaoEmY = 10;
            int numeroPoltrona = 0;
            for(int i = 0; i < TamanhoSessaoEmX; i++)
            {
                for(int j = 0; j<TamanhoSessaoEmY; j++)
                {
                    poltronas.Add(new PoltronaAppModel
                    {
                        Descricao = numeroPoltrona.ToString(),
                        X = i,
                        Y = j
                    });
                }
            }
        
        }
    }
}
