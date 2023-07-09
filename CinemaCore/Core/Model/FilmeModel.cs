﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaCore.Core.Model
{
    public class FilmeModel
    {
        public int Codigo { get; set; }
        public string NomeFilme { get; set; }
        public string UrlImagem { get; set; }
        public string Sinopse { get; set; }
        public string TipoFilme { get; set; }
        public TimeSpan Duracao { get; set; }
        public ClassificacaoModel Classificacao { get; set; }
        public int AnoLancamento { get; set; }
    }
}
