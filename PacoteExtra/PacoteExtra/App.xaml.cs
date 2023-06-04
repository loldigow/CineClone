using PacoteExtra.Componentes.ExemplosDeUso.Botao;
using PacoteExtra.Componentes.ExemplosDeUso.CronogramaProgramacaoselector;
using PacoteExtra.Componentes.ExemplosDeUso.DateTimeLineSwipe;
using PacoteExtra.Componentes.ExemplosDeUso.DropDown;
using PacoteExtra.Componentes.ExemplosDeUso.ExemploCollectionView;
using PacoteExtra.Componentes.ExemplosDeUso.SearchCustom;
using PacoteExtra.Componentes.ExemplosDeUso.TabView;
using PacoteExtra.Componentes.ExemplosDeUso.TappedCustom;
using PacoteExtra.Services;
using PacoteExtra.Views;
using PacoteExtra.Views.BuscaShopping;
using PacoteExtra.Views.Inicio;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PacoteExtra
{
    public partial class App : Application
    {
        public static double WidthApp => DeviceDisplay.MainDisplayInfo.Width;
        public static double WidthApp3 = WidthApp / 5;
        public static double HeightApp;
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage( new InicioPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
