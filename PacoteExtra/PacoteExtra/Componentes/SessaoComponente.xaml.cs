using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    }
}