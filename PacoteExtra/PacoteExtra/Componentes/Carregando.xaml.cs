using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PacoteExtra.Componentes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carregando : PopupPage
    {
        public Carregando(string mensagem)
        {
            InitializeComponent();
            LabelCarregando.Text = mensagem;
            this.BackgroundColor = Color.FromRgba(0,0,0,0.5);
        }

        public static async Task CarregueEnquandoAcaoEstiverRodando(Func<Task> acao, string textoCarregando)
        {
            var carregandoPage = new Carregando(textoCarregando);
            Device.BeginInvokeOnMainThread(() => { App.Current.MainPage.Navigation.PushPopupAsync(carregandoPage); });
            try
            {
                await Task.Run(acao);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Device.BeginInvokeOnMainThread(() => { App.Current.MainPage.Navigation.PopPopupAsync(); });
            }

        }
    }
}