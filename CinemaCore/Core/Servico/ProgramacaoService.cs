using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CinemaCore.Core.Servico
{
    public class ProgramacaoService
    {
        private readonly ISessaoRepository _sessaoRepository = DependencyService.Get<ISessaoRepository>();

        public async Task<ProgramacaoModel> Obtenhaprogramacao(FilmeModel filme, FilialCinemaModel filial, DateTime dataInicioBusca, DateTime DataFimBusca)
        {
            var programacao = new ProgramacaoModel();
            programacao.Filme = filme;
            programacao.Filial = filial;
            programacao.Sessao.AddRange(await _sessaoRepository.ObtenhaSessoes(filme.Codigo, filial.Codigo, dataInicioBusca, DataFimBusca));
            return programacao;

        }
    }
}
