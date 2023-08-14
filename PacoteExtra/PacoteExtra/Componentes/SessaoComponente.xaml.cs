using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PacoteExtra.Componentes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SessaoComponente : ContentView
    {
        public static readonly BindableProperty TamanhoEmXProperty = BindableProperty.Create(nameof(TamanhoEmX), typeof(int), typeof(SessaoComponente), null);
        public static readonly BindableProperty TamanhoEmYProperty = BindableProperty.Create(nameof(TamanhoEmY), typeof(int), typeof(SessaoComponente), null);
        public int TamanhoEmX
        {
            get => (int)GetValue(TamanhoEmXProperty);
            set => SetValue(TamanhoEmXProperty, value);
        }
        public int TamanhoEmY
        {
            get => (int)GetValue(TamanhoEmYProperty);
            set => SetValue(TamanhoEmYProperty, value);
        }
        public SessaoComponente()
        {
            InitializeComponent();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == nameof(TamanhoEmX) || propertyName == nameof(TamanhoEmY))
            {
                AjusteLocalCinema();
            }
        }

        private void AjusteLocalCinema()
        {

            if (TamanhoEmX != 0 && TamanhoEmY != 0)
            {
                for (var i = 0; i < TamanhoEmX; i++)
                {
                    GridPoltronas.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Auto });
                }
                for (var i = 0; i < TamanhoEmY; i++)
                {
                    GridPoltronas.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
                }

                int cont = 0;
                for(int i = 0; i< TamanhoEmX; i++)
                {
                    for(int j = 0; j < TamanhoEmY; j++)
                    {
                        GridPoltronas.Children.Add(new PoltronaComponente()
                        {
                            DescricaoPoltrona = $"{cont}",
                            SelecaoCommand = new Command((e) => {
                                AcioneEventoDeSelecao(e);
                            })
                        }, j, i) ;
                        cont++;
                    }
                }
            }

        }

        private void AcioneEventoDeSelecao(object e)
        {
        }
    }
}