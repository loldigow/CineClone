using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using PacoteExtra.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PacoteExtra.Core.Services
{
    public class IngressosService
    {
        private readonly IIngressoRepository _ingressoRepository = DependencyService.Resolve<IIngressoRepository>();
        private readonly IFilmeRepository _filmeRepository = DependencyService.Resolve<IFilmeRepository>();
        private readonly IFilialRepository _filialRepository = DependencyService.Resolve<IFilialRepository>();
        private readonly ISessaoRepository _sessaoRepository = DependencyService.Resolve<ISessaoRepository>();
        private readonly IPoltronaRepository _poltronaRepository = DependencyService.Resolve<IPoltronaRepository>();
        public async Task<List<IngressoAppModel>> ObtenhaUltimosIngressosDaFilial(int codigoFilial)
        {
            List<IngressoAppModel> listaIngressos = new List<IngressoAppModel>();
            var ingressos = await _ingressoRepository.ObtenhaTodosIngressosAdquiridos();

            foreach (var ingresso in ingressos)
            {
                var ingressoAppModel = new IngressoAppModel();
                ingressoAppModel.Filme = await _filmeRepository.ObtenhaDetalhesFilme(ingresso.Filme);
                ingressoAppModel.FilialCinema = await _filialRepository.ObtenhaFilialPorCodigo(ingresso.FilialCinema);
                ingressoAppModel.Sessao = await _sessaoRepository.ObtenhaSessaoPorCodigo(ingresso.Sessao);
                var poltronasModel = await _poltronaRepository.ObtenhaPoltronaPorCodigos(ingresso.Poltronas);
                ingressoAppModel.Poltronas.AddRange(poltronasModel);
                listaIngressos.Add(ingressoAppModel);
            }
            return listaIngressos;
        }
    }
}
