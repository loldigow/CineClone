using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCore.Core.Repository
{
    public class FilialRepository : IFilialRepository
    {
        public Task<FilialCinemaModel> ObtenhaFilialPorCodigo(int codigoFilial)
        {
            throw new NotImplementedException();
        }

        public List<FilialCinemaModel> ObtenhaPorDescricao(string descricao)
        {
            throw new NotImplementedException();
        }

        public List<FilialCinemaModel> ObtenhaTodos()
        {
            throw new NotImplementedException();
        }

        public FilialCinemaModel ObtenhaUltimoCinema()
        {
            return null;
        }

        public void SelecioneFilial(int filial)
        {
            throw new NotImplementedException();
        }

        Task<List<CartazFilial>> IFilialRepository.ObtenhaFilmesEmCartazFilial(int codigoFilial)
        {
            throw new NotImplementedException();
        }

        Task<List<FilialCinemaModel>> IFilialRepository.ObtenhaPorDescricao(string descricao)
        {
            throw new NotImplementedException();
        }

        Task<FilialCinemaModel> IFilialRepository.ObtenhaUltimoCinema()
        {
            throw new NotImplementedException();
        }

        void IFilialRepository.SelecioneFilial(int filial)
        {
            throw new NotImplementedException();
        }
    }
}
