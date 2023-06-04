using CommunityToolkit.Mvvm.ComponentModel;
using PacoteExtra.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PacoteExtra.Componentes.ExemplosDeUso.TabView
{
    public partial class MinhasComprasTemplateExemploMideModel : ObservableObject
    {
        [ObservableProperty]
        public List<CollectionViewModel> minhasCompras;

        public MinhasComprasTemplateExemploMideModel()
        {
            MinhasCompras = new List<CollectionViewModel>();
            MinhasCompras.Add(new CollectionViewModel()
            {
                Titulo = "BATMAN",
                Descricao = "Sala 1",
                Descricao1 = "21:00",
                Descricao2 = "F1, F2",
                Descricao3 = "26/12/2023",
                 Descricao4 = "CineFlix Aparecida Shopping"
            });
        }
    }
}
