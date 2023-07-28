using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCore.Core.Interface
{
    public interface IFilialRepository
    {
        Task<FilialCinemaModel> ObtenhaUltimoCinema();
        Task<List<FilialCinemaModel>> ObtenhaPorDescricao(string descricao);
        void SelecioneFilial(int filial);
        Task<List<CartazFilial>> ObtenhaFilmesEmCartazFilial(int codigoFilial);
        Task<FilialCinemaModel> ObtenhaFilialPorCodigo(int codigoFilial);
    }
}
