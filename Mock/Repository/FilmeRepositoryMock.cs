using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using CinemaCore.Core.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mock.Repository
{
    public class FilmeRepositoryMock : IFilmeRepository
    {
        private List<FilmeModel> _filmes = new List<FilmeModel>();
        private List<int> _codigoFilmesfavoritos = new List<int>();
        public FilmeRepositoryMock()
        {
            _filmes.Add(new FilmeModel { Codigo = 1, UrlImagem = "https://i0.wp.com/animagos.com.br/wp-content/uploads/2019/01/DVD-COG-v1.png?resize=759%2C1080" });
            _filmes.Add(new FilmeModel { Codigo = 2, UrlImagem = "https://cabanadoleitor.com.br/wp-content/uploads/2022/05/Tudo-em-Todo-o-Lugar-ao-Mesmo-Tempo-1280x1881.webp" });
            _filmes.Add(new FilmeModel { Codigo = 3, UrlImagem = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgWo55O_9TONhFgy8-npvXqlwr0DWBiD8rrwk9k-_sQujTC9obxblHfhY1BWbCajwF5r8&usqp=CAU" });
            _filmes.Add(new FilmeModel { Codigo = 4, UrlImagem = "https://cdnim.prd.cineticket.com.br/asset/movie/7841/dungeons-and-dragons-honra-entre-rebeldes-poster-tablet-4969c.jpg" });
            _filmes.Add(new FilmeModel { Codigo = 5, UrlImagem = "https://a-static.mlcdn.com.br/800x560/poster-cartaz-o-hobbit-a-desolacao-de-smaug-c-pop-arte-poster/poparteskins2/15938538942/3379a0a59be06c210b747afa9f6b5512.jpeg" });
        }

        public List<FilmeModel> Obtenhafavoritos()
        {
            return _filmes.Where(x => _codigoFilmesfavoritos.Any(codigo => codigo == x.Codigo)).ToList();
        }

        public List<FilmeModel> ObtenhaFilmesDeCartaz()
        {
            return _filmes;
        }
    }
}
