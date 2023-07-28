using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mock.Repository
{
    public class IngressosMock : IIngressoRepository
    {
        private List<IngressoModel> _ingressos;
        public IngressosMock()
        {
            _ingressos = new List<IngressoModel>()
            {
                new IngressoModel()
                {
                    Codigo = 1,
                    FilialCinema = 1,
                    Filme = 1,
                    Sessao = 1,
                    Poltronas = new List<int> (){ 1, 2 }
                }
            };
        }
        public async Task<List<IngressoModel>> ObtenhaTodosIngressosAdquiridos()
        {

            await Task.Delay(1000);
            return _ingressos;
        }
    }
}
