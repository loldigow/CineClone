using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCore.Core.Interface
{
    public interface ISessaoRepository
    {
        Task<List<SessaoModel>> ObtenhaSessoes(int codigoFilme, int codigoFilial, DateTime dataInicioBusca, DateTime dataFimBusca);
    }
}
