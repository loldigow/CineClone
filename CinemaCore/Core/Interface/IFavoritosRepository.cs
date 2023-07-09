using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCore.Core.Interface
{
    public interface IFavoritosRepository
    {
        Task<List<FavoritoModel>> ObtenhaFavoritosAsync();
        Task AdicioneAoFavoritos(FavoritoModel favorito);
        Task RemovaFavorito(FavoritoModel favorito);
        Task<bool> FilmeEhfavorito(int codigoFilme);
    }
}
