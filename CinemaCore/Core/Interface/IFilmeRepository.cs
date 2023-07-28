using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCore.Core.Interface
{
    public interface IFilmeRepository
    {
        Task<FilmeModel> ObtenhaDetalhesFilme(int codigo);
        Task<string> ObtenhaNomeFilme(int filme);
        Task<List<FilmeModel>> ObtenhaTodosFilmesAtivos();
    }
}
