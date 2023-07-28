using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PacoteExtra.Core.Services
{
    public class ProgramacaoService
    {
        private readonly ISessaoRepository _sessaoRepository = DependencyService.Get<ISessaoRepository>();
        private readonly IFilmeRepository _filmeRepository = DependencyService.Get<IFilmeRepository>();

        public async Task<ProgramacaoModel> Obtenhaprogramacao(FilmeModel filme, FilialCinemaModel filial, DateTime dataInicioBusca, DateTime DataFimBusca)
        {
            var programacao = new ProgramacaoModel();
            programacao.Filme = filme;
            programacao.Filial = filial;
            programacao.Sessao.AddRange(await _sessaoRepository.ObtenhaSessoes(filme.Codigo, filial.Codigo, dataInicioBusca, DataFimBusca));
            return programacao;

        }

        public async Task<List<ProgramacaoModel>> ObtenhaSessoesDaFilial(int codigoFilial, DateTime dataInicioBusca, DateTime dataFimBusca)
        {
            var programacoes = new List<ProgramacaoModel>();
            var filmes = await _filmeRepository.ObtenhaTodosFilmesAtivos();
            foreach (var filme in filmes)
            {
                var programacao = new ProgramacaoModel()
                {
                    Filme = filme,
                };

                foreach(var sessao in await _sessaoRepository.ObtenhaSessoes(filme.Codigo, codigoFilial, dataInicioBusca, dataFimBusca))
                {
                    programacao.Sessao.Add(sessao);
                }
                programacoes.Add(programacao);
            }
            return programacoes;

        }
    }
}
