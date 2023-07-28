using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using CinemaCore.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PacoteExtra.Core.Services
{
    public class FilmeService
    {
        private readonly IFilmeRepository _filmeRepository;
        private readonly IFavoritosRepository _favoritoRepository;
        private readonly IFilialRepository _filialRepository;
        private readonly ISessaoRepository _sessaoRepository;
        public FilmeService() 
        {
            _filmeRepository = DependencyService.Get<IFilmeRepository>();
            _favoritoRepository = DependencyService.Get<IFavoritosRepository>();
            _filialRepository = DependencyService.Get<IFilialRepository>();
            _sessaoRepository = DependencyService.Get<ISessaoRepository>();
        }

        public async Task<List<FilmeModel>> ObtenhaBilheteriaDeFilmesPorFilial(int codigoFilial)
        {
            var sessoesAtivas = await _sessaoRepository.ObtenhaSessoesPorFilial(codigoFilial, DateTime.Now, DateTime.Now.AddDays(15));

            var listaFilmes = new List<FilmeModel>();
            foreach(var filme in sessoesAtivas.Select(x => x.CodigoFilme).Distinct())
            {
                listaFilmes.Add(await _filmeRepository.ObtenhaDetalhesFilme(filme));
            }
            return listaFilmes;
        }

        public async Task<List<FavoritoModel>> ObtenhaBilheteriesAdicionadasAoFavoritoAsync()
        {
           return await _favoritoRepository.ObtenhaFavoritosAsync();
        }
        public async Task AdicioneAosFavoritos(int codigoFilme)
        {
            await _favoritoRepository.AdicioneAoFavoritos(new FavoritoModel { CodigoFilme = codigoFilme});
        }

        public async Task Removafavorito(int codigoFilme)
        {
            await _favoritoRepository.RemovaFavorito(new FavoritoModel { Codigo = codigoFilme});
        }

        public async Task<bool> FilmeEhFavorito(int codigoFilme)
        {
            return await _favoritoRepository.FilmeEhfavorito(codigoFilme);
        }

        public async Task<FilmeModel> ObtenhaDadosDoFilme(int codigoFilme)
        {
            return await _filmeRepository.ObtenhaDetalhesFilme(codigoFilme);
        }
    }
}
