using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using CinemaCore.Core.Repository;
using Mock.Repository;
using PacoteExtra.Componentes.ExemplosDeUso;
using PacoteExtra.Componentes.ExemplosDeUso.Botao;
using PacoteExtra.Componentes.ExemplosDeUso.CronogramaProgramacaoselector;
using PacoteExtra.Componentes.ExemplosDeUso.DateTimeLineSwipe;
using PacoteExtra.Componentes.ExemplosDeUso.DropDown;
using PacoteExtra.Componentes.ExemplosDeUso.ExemploCollectionView;
using PacoteExtra.Componentes.ExemplosDeUso.Favorito;
using PacoteExtra.Componentes.ExemplosDeUso.Loading;
using PacoteExtra.Componentes.ExemplosDeUso.SearchCustom;
using PacoteExtra.Componentes.ExemplosDeUso.TabView;
using PacoteExtra.Componentes.ExemplosDeUso.TappedCustom;
using PacoteExtra.MeuMapper;
using PacoteExtra.Models;
using PacoteExtra.Services;
using PacoteExtra.Views;
using PacoteExtra.Views.BuscaShopping;
using PacoteExtra.Views.Inicio;
using System;
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
            DependencyService.RegisterSingleton<IFilialRepository>(new FilialRepositoryMock());
            DependencyService.RegisterSingleton<IFilmeRepository>(new FilmeRepositoryMock());
            DependencyService.RegisterSingleton<IFavoritosRepository>(new FavoritosMock());
            DependencyService.RegisterSingleton<ISessaoRepository>(new SessaoRepositoryMock());
            Mapper.CrieMapeamento();
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
