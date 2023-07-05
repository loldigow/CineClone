using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaCore.Core.Interface
{
    public interface IFilmeRepository
    {
        List<FilmeModel> Obtenhafavoritos();
        List<FilmeModel> ObtenhaFilmesDeCartaz();
    }
}
