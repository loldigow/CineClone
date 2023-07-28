using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCore.Core.Interface
{
    public interface ISessaoRepository
    {
        Task<SessaoModel> ObtenhaSessaoPorCodigo(int sessao);
        Task<List<SessaoModel>> ObtenhaSessoes(int codigoFilme, int codigoFilial, DateTime dataInicioBusca, DateTime dataFimBusca);
        Task<List<SessaoModel>> ObtenhaSessoesPorFilial(int codigoFilial, DateTime dataInicioBusca, DateTime dataFimBusca);
    }
}
