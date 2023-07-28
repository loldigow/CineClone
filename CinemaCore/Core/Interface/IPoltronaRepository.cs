using CinemaCore.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CinemaCore.Core.Interface
{
    public interface IPoltronaRepository
    {
        Task<PoltronaModel> ObtenhaPoltronaPorCodigo(int codigopoltrona);
        Task<List<PoltronaModel>> ObtenhaPoltronaPorCodigos(List<int> codigosPoltronas);
    }
}
