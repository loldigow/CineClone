using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mock.Repository
{
    public class FavoritosMock : IFavoritosRepository
    {
        List<FavoritoModel> _favoritos = new List<FavoritoModel>();
        private int gen = 0;
        public async Task<List<FavoritoModel>> ObtenhaFavoritosAsync()
        {
            await Task.Delay(1000);
            return _favoritos;
        }

        public async Task AdicioneAoFavoritos(FavoritoModel favorito)
        {
            await Task.Delay(300);
            if (!_favoritos.Any(x => x.CodigoFilme == favorito.CodigoFilme))
            {
                favorito.Codigo = ++ gen;
                _favoritos.Add(favorito);
            }
        }

        public async Task RemovaFavorito(FavoritoModel favoritoModel)
        {
            await Task.Delay(1000);
            var favorito = _favoritos.First(x => x.CodigoFilme == favoritoModel.CodigoFilme);
            if(favorito != null)
            {
                _favoritos.Remove(favorito);
            }
        }

        public async Task<bool> FilmeEhfavorito(int codigoFilme)
        {
            await Task.Delay(500);
            return _favoritos.Any(x => x.CodigoFilme == codigoFilme);
        }
    }
}
