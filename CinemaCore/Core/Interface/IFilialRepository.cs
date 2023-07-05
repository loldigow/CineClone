using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaCore.Core.Interface
{
    public interface IFilialRepository
    {
        FilialCinemaModel ObtenhaUltimoCinema();
        List<FilialCinemaModel> ObtenhaPorDescricao(string descricao);
        void SelecioneFilial(int filial);
    }
}
