using CinemaCore.Core.Interface;
using Mock.Repository;
using PacoteExtra.MeuMapper;
using PacoteExtra.Views.Inicio;
using Xamarin.Essentials;
using Xamarin.Forms;
using PacoteExtra.Core;
using PacoteExtra.Componentes.ExemplosDeUso.Poltrona;
using PacoteExtra.Componentes.ExemplosDeUso.SessaoComponente;

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
            this.RegistreDependencias();
            Mapper.CrieMapeamento();

            MainPage = new NavigationPage( new SessaoExemplo());
        }

        //protected override void OnStart()
        //{
        //}

        //protected override void OnSleep()
        //{
        //}

        //protected override void OnResume()
        //{
        //}
    }
}
