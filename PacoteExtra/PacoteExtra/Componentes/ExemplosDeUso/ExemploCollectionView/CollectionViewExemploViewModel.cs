using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace PacoteExtra.Componentes.ExemplosDeUso.ExemploCollectionView
{
    partial class CollectionViewExemploViewModel : ObservableObject
    {
        [ObservableProperty]
        List<CollectionViewModel> colecao;

        [RelayCommand]
        void AoClicarEmElemento(object item)
        {
            if(item is CollectionViewModel teste)
            {

            }
        }

        public CollectionViewExemploViewModel()
        {
            Colecao = new List<CollectionViewModel>()
            {
                new CollectionViewModel()
                {
                    Id = 1,
                    Titulo = "Shopping 1",
                    Descricao = "12 Km",
                    Descricao1 = "Avenida independencia",
                    Descricao2 = "Aparecida de Goiânia - GO",
                    PropriedadeBoleana= true,
                },
                new CollectionViewModel()
                {
                    Id = 2,
                    Titulo = "Shopping 2",
                    Descricao = "15 Km",
                    Descricao1 = "Avenida Cardoso 2",
                    Descricao2 = "Aparecida de Goiânia - GO",
                },
                new CollectionViewModel()
                {
                    Id = 2,
                    Titulo = "Shopping 3",
                    Descricao = "25 Km",
                    Descricao1 = "Aenida Garavelo",
                    Descricao2 = "Goiânia - GO",
                }
            };
        }
    }
}
