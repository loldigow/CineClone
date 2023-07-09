using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using CinemaCore.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CinemaCore.Core.Servico
{
    public class FilmeService
    {
        private readonly IFilmeRepository _filmeRepository;
        private readonly IFavoritosRepository _favoritoRepository;
        private readonly IFilialRepository _filialRepository;
        public FilmeService() 
        {
            _filmeRepository = DependencyService.Get<IFilmeRepository>();
            _favoritoRepository = DependencyService.Get<IFavoritosRepository>();
            _filialRepository = DependencyService.Get<IFilialRepository>();
        }

        public async Task<List<FilmeModel>> ObtenhaBilheteriaDeFilmesPorFilial(int codigoFilial)
        {
            var filmesEmCartaznaFilial = await _filialRepository.ObtenhaFilmesEmCartazFilial(codigoFilial);
            var listaFilmes = new List<FilmeModel>();
            foreach(var i in filmesEmCartaznaFilial)
            {
                listaFilmes.Add(await _filmeRepository.ObtenhaDetalhesFilme(i.CodigoFilme));
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
