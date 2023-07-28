using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;

namespace Mock.Repository
{
    public class PoltronaRepositoryMock : IPoltronaRepository
    {
        List<PoltronaModel> _poltronas = new List<PoltronaModel>();
        public PoltronaRepositoryMock()
        {
            _poltronas.Add(new PoltronaModel() { Numeiro = 1, Descricao = "A"});
            _poltronas.Add(new PoltronaModel() { Numeiro = 2, Descricao = "B"});
        }
        public async Task<PoltronaModel> ObtenhaPoltronaPorCodigo(int codigopoltrona)
        {
            await Task.Delay(22);
            return _poltronas.First(x => x.Numeiro == codigopoltrona);
        }

        public async Task<List<PoltronaModel>> ObtenhaPoltronaPorCodigos(List<int> codigosPoltronas)
        {
            await Task.Delay(1);
            return _poltronas.Where(x => codigosPoltronas.Contains(x.Numeiro)).ToList();
        }
    }
}
