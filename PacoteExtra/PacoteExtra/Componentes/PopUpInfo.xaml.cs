using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PacoteExtra.Componentes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpInfo : PopupPage
    {
        public PopUpInfo(string titulo = "", string texto = "")
        {
            InitializeComponent();
            LabelTitulo.Text = titulo;
            LabelMensagem.Text = texto;
            BotaoFechar.AoPressionar = new Command(() =>
            {
                 App.Current.MainPage.Navigation.PopPopupAsync();
            });
    }
    }
}