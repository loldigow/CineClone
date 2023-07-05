using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaCore.Core.Repository
{
    public class FilialRepository : IFilialRepository
    {
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
    }
}
