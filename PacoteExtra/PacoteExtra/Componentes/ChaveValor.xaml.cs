using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PacoteExtra.Componentes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChaveValor : ContentView
    {
        public static readonly BindableProperty ChaveProperty = BindableProperty.Create(nameof(Chave), typeof(string), typeof(ChaveValor), null);
        public static readonly BindableProperty ValorProperty = BindableProperty.Create(nameof(Valor), typeof(string), typeof(ChaveValor), null);
        public static readonly BindableProperty OrientacaoTuplaProperty = BindableProperty.Create(nameof(OrientacaoTupla), typeof(StackOrientation), typeof(ChaveValor), null);
        public StackOrientation OrientacaoTupla
        {
            get => (StackOrientation)GetValue(OrientacaoTuplaProperty); 
            set => SetValue(OrientacaoTuplaProperty, value);
        }
        public string Chave
        {
            get => (string)GetValue(ChaveProperty); 
            set => SetValue(ChaveProperty, value);
        }
        public string Valor
        {
            get => (string)GetValue(ValorProperty);
            set => SetValue(ValorProperty, value);
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if(propertyName == nameof(Valor))
            {
                LabelValor.Text = Valor;
            }
            if(propertyName == nameof(OrientacaoTupla))
            {
                //OrientacaoTupla
                StackChaveValor.Orientation = OrientacaoTupla;
            }
            if (propertyName == nameof(Chave))
            {
                LabelChave.Text = Chave;
            }
        }
        public ChaveValor()
        {
            InitializeComponent();
        }
    }
}