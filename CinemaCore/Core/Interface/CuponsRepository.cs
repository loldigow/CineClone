using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCore.Core.Interface
{
    public interface ICuponsRepository
    {
        public Task<List<CuponsModel>> ObtenhaCuponsDescontoPorFilial(int codigoFilial);
    }
}
