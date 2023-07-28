using AutoMapper.Internal.Mappers;
using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PacoteExtra.Models
{
    public class FilmeViewModel
    {
        public int Codigo { get; set; }
        public string NomeFilme { get; set; }
        public string UrlImagem { get; set; }
        public string Sinopse { get; set; }
        public string TipoFilme { get; set; }
        public TimeSpan Duracao { get; set; }
        public ClassificacaoModel Classificacao { get; set; }
        public int AnoLancamento { get; set; }

        public string DescricaoTipoETempo => $"{TipoFilme} | {Duracao}";

    }
}
