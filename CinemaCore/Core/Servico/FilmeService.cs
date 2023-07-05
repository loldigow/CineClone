using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CinemaCore.Core.Servico
{
    public class FilmeService
    {
        private readonly IFilmeRepository _filmeRepository;
        public FilmeService() 
        {
            _filmeRepository = DependencyService.Get<IFilmeRepository>();
        }
        public List<FilmeModel> ObtenhaBilheteriaDeFilmes()
        {
            return _filmeRepository.ObtenhaFilmesDeCartaz();
        }

        public List<FilmeModel> ObtenhaBilheteriesAdicionadasAoFavorito()
        {
            return _filmeRepository.Obtenhafavoritos();
        }
    }
}
