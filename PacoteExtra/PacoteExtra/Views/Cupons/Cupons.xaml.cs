using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PacoteExtra.Views.Cupons
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cupons : ContentView
    {
        public Cupons()
        {
            InitializeComponent();
            BoxDireita.IsVisible = false;
            GuiaCupons.IsVisible = false;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var evt = (TappedEventArgs)e;
            if(evt != null && evt.Parameter is string opcao)
            {
                GuiaIngressos.IsVisible = BoxEsquerda.IsVisible = opcao == "ingressos";
                GuiaCupons.IsVisible = BoxDireita.IsVisible = opcao == "cupons";
            }
        }
    }
}