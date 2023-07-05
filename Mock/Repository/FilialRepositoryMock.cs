using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Mock.Repository
{
    public class FilialRepositoryMock : IFilialRepository
    {
        private List<FilialCinemaModel> FilialCinemas = new List<FilialCinemaModel>();
        private FilialCinemaModel Ultimafilial;
        private int CodigoGenerator = 0;
        public FilialRepositoryMock()
        {
            FilialCinemas.Add(new FilialCinemaModel
            {
                Codigo = ++CodigoGenerator,
                Descricao = "Cineflix aparecida de goiânia",
                Distancia = 2.94,
                Endereco = "Av. Independencia",
                Cidade = "Aparecida de goiania",
                Estado = "Go"
            });
            FilialCinemas.Add(new FilialCinemaModel
            {
                Codigo = ++CodigoGenerator,
                Descricao = "Cineflix Shopping Sul - Valparaiso",
                Distancia = 28.9,
                Endereco = "Rod BR 040",
                Cidade = "Valparaíso de Goias",
                Estado = "GO"
            });
            FilialCinemas.Add(new FilialCinemaModel
            {
                Codigo = ++CodigoGenerator,
                Descricao = "Cineflix Shopping Norte - Montes belos",
                Distancia = 680,
                Endereco = "Rod BR 023",
                Cidade = "Montes Belos",
                Estado = "GO"
            });
            FilialCinemas.Add(new FilialCinemaModel
            {
                Codigo = ++CodigoGenerator,
                Descricao = "Flaboyant - Goiania do Sul",
                Distancia = 350,
                Endereco = "Avenida são Carlos",
                Cidade = "Montes Belos",
                Estado = "GO"
            });
        }

        public List<FilialCinemaModel> ObtenhaPorDescricao(string descricao)
        {
            if (!string.IsNullOrEmpty(descricao))
            {
                var descricaoHigienizada = descricao.ToUpper();
                return FilialCinemas.Where(x => x.Descricao.ToUpper().Contains(descricaoHigienizada)).ToList();
            }
            return FilialCinemas;
        }

        public List<FilialCinemaModel> ObtenhaTodos()
        {
            return FilialCinemas.ToList();
        }

        public FilialCinemaModel ObtenhaUltimoCinema()
        {
            if (Ultimafilial == null)
            {
                var index = new Random().Next() % 3;
                Ultimafilial = FilialCinemas.ElementAt(index); 
            }
            return Ultimafilial;
        }

        public void SelecioneFilial(int filial)
        {
            Ultimafilial = FilialCinemas.FirstOrDefault(x => x.Codigo == filial);
        }
    }
}
