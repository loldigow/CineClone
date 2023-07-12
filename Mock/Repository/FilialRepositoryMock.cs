using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mock.Repository
{
    public class FilialRepositoryMock : IFilialRepository
    {
        private List<FilialCinemaModel> _filialCinemas = new List<FilialCinemaModel>();
        private List<CartazFilial> _cartazFilial = new List<CartazFilial>();
        private FilialCinemaModel Ultimafilial;
        private int CodigoGeneratorFilial = 0;
        private int CodigoGeneratorCartazFilme = 0;
        public FilialRepositoryMock()
        {
            _filialCinemas.Add(new FilialCinemaModel
            {
                Codigo = ++CodigoGeneratorFilial,
                Descricao = "Cineflix aparecida de goiânia",
                Distancia = 2.94,
                Endereco = "Av. Independencia",
                Cidade = "Aparecida de goiania",
                Estado = "Go"
            });
            _filialCinemas.Add(new FilialCinemaModel
            {
                Codigo = ++CodigoGeneratorFilial,
                Descricao = "Cineflix Shopping Sul - Valparaiso",
                Distancia = 28.9,
                Endereco = "Rod BR 040",
                Cidade = "Valparaíso de Goias",
                Estado = "GO"
            });
            _filialCinemas.Add(new FilialCinemaModel
            {
                Codigo = ++CodigoGeneratorFilial,
                Descricao = "Cineflix Shopping Norte - Montes belos",
                Distancia = 680,
                Endereco = "Rod BR 023",
                Cidade = "Montes Belos",
                Estado = "GO"
            });
            _filialCinemas.Add(new FilialCinemaModel
            {
                Codigo = ++CodigoGeneratorFilial,
                Descricao = "Flaboyant - Goiania do Sul",
                Distancia = 350,
                Endereco = "Avenida são Carlos",
                Cidade = "Montes Belos",
                Estado = "GO"
            });

            _cartazFilial.Add(new CartazFilial()
            {
                Codigo = ++CodigoGeneratorCartazFilme,
                CodigoFilial = 1,
                CodigoFilme = 1
            });

            _cartazFilial.Add(new CartazFilial()
            {
                Codigo = ++CodigoGeneratorCartazFilme,
                CodigoFilial = 1,
                CodigoFilme = 2
            });

            _cartazFilial.Add(new CartazFilial()
            {
                Codigo = ++CodigoGeneratorCartazFilme,
                CodigoFilial = 1,
                CodigoFilme = 3
            });

            _cartazFilial.Add(new CartazFilial()
            {
                Codigo = ++CodigoGeneratorCartazFilme,
                CodigoFilial = 1,
                CodigoFilme = 4
            });

            _cartazFilial.Add(new CartazFilial()
            {
                Codigo = ++CodigoGeneratorCartazFilme,
                CodigoFilial = 1,
                CodigoFilme = 5
            });

            _cartazFilial.Add(new CartazFilial()
            {
                Codigo = ++CodigoGeneratorCartazFilme,
                CodigoFilial = 2,
                CodigoFilme = 1
            });

            _cartazFilial.Add(new CartazFilial()
            {
                Codigo = ++CodigoGeneratorCartazFilme,
                CodigoFilial = 2,
                CodigoFilme = 3
            });

            _cartazFilial.Add(new CartazFilial()
            {
                Codigo = ++CodigoGeneratorCartazFilme,
                CodigoFilial = 2,
                CodigoFilme = 4
            });

            _cartazFilial.Add(new CartazFilial()
            {
                Codigo = ++CodigoGeneratorCartazFilme,
                CodigoFilial = 3,
                CodigoFilme = 5
            });

            _cartazFilial.Add(new CartazFilial()
            {
                Codigo = ++CodigoGeneratorCartazFilme,
                CodigoFilial = 4,
                CodigoFilme = 1
            });

            _cartazFilial.Add(new CartazFilial()
            {
                Codigo = ++CodigoGeneratorCartazFilme,
                CodigoFilial = 4,
                CodigoFilme = 2
            });

            _cartazFilial.Add(new CartazFilial()
            {
                Codigo = ++CodigoGeneratorCartazFilme,
                CodigoFilial = 4,
                CodigoFilme = 3
            });

            _cartazFilial.Add(new CartazFilial()
            {
                Codigo = ++CodigoGeneratorCartazFilme,
                CodigoFilial = 4,
                CodigoFilme = 5
            });

            _cartazFilial.Add(new CartazFilial()
            {
                Codigo = ++CodigoGeneratorCartazFilme,
                CodigoFilial = 4,
                CodigoFilme = 4
            });

        }

        public async Task<List<FilialCinemaModel>> ObtenhaPorDescricao(string descricao)
        {
            await Task.Delay(100);
            if (!string.IsNullOrEmpty(descricao))
            {
                var descricaoHigienizada = descricao.ToUpper();
                return _filialCinemas.Where(x => x.Descricao.ToUpper().Contains(descricaoHigienizada)).ToList();
            }
            return _filialCinemas;
        }

        public List<FilialCinemaModel> ObtenhaTodos()
        {
            return _filialCinemas.ToList();
        }

        public async Task<FilialCinemaModel> ObtenhaUltimoCinema()
        {
            await Task.Delay(300);
            if (Ultimafilial == null)
            {
                var index = new Random().Next() % 3;
                Ultimafilial = _filialCinemas.ElementAt(index); 
            }
            return Ultimafilial;
        }

        public void SelecioneFilial(int filial)
        {
            Ultimafilial = _filialCinemas.FirstOrDefault(x => x.Codigo == filial);
        }

        public async Task<List<CartazFilial>> ObtenhaFilmesEmCartazFilial(int codigoFilial)
        {
            await Task.Delay(250);
            return _cartazFilial.Where(x => x.CodigoFilial == codigoFilial).ToList();
        }
    }
}
