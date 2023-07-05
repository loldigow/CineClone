using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CinemaCore.Core.Servico
{
    public class ShoppingService
    {
        public IFilialRepository shoppingRepositoty;
        public ShoppingService()
        {
            shoppingRepositoty = DependencyService.Get<IFilialRepository>();
        }

        public FilialCinemaModel ObtenhaUltimaFiliaBuscada()
        {
            return shoppingRepositoty.ObtenhaUltimoCinema();
        }

        public void MarqueSelecaoDeFilial(int codigo)
        {
            shoppingRepositoty.SelecioneFilial(codigo);
        }

        public async Task<List<FilialCinemaModel>> ObtenhaPorDescricaoAsync(string descricao)
        {
            await Task.Delay(5000);
            return shoppingRepositoty.ObtenhaPorDescricao(descricao);
        }
    }
}
