using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PacoteExtra.Core.Services
{
    public class ShoppingService
    {
        public IFilialRepository shoppingRepositoty;
        public ShoppingService()
        {
            shoppingRepositoty = DependencyService.Get<IFilialRepository>();
        }

        public async Task<FilialCinemaModel> ObtenhaUltimaFiliaBuscada()
        {
            return await shoppingRepositoty.ObtenhaUltimoCinema();
        }

        public void MarqueSelecaoDeFilial(int codigo)
        {
            shoppingRepositoty.SelecioneFilial(codigo);
        }

        public async Task<List<FilialCinemaModel>> ObtenhaPorDescricaoAsync(string descricao)
        {
            return await shoppingRepositoty.ObtenhaPorDescricao(descricao);
        }

      
    }
}
