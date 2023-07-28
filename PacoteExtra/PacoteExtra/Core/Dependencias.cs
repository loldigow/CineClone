using CinemaCore.Core.Interface;
using Mock.Repository;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace PacoteExtra
{
    public static class Dependencias
    {
        public static void RegistreDependencias(this App app)
        {
            DependencyService.RegisterSingleton<IFilialRepository>(new FilialRepositoryMock());
            DependencyService.RegisterSingleton<IFilmeRepository>(new FilmeRepositoryMock());
            DependencyService.RegisterSingleton<IFavoritosRepository>(new FavoritosMock());
            DependencyService.RegisterSingleton<ISessaoRepository>(new SessaoRepositoryMock());
            DependencyService.RegisterSingleton<IIngressoRepository>(new IngressosMock());
            DependencyService.RegisterSingleton<ICuponsRepository>(new CuponsMock());
            DependencyService.RegisterSingleton<IPoltronaRepository>(new PoltronaRepositoryMock());
        }
    }
}
