using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaCore.Core.Model
{
    public class SessaoModel
    {
        public int Codigo { get; set; }
        public int CodigoFilial { get; set; }
        public int CodigoFilme { get; set; }
        public string DescricaoSessao { get; set; }
        public DateTime DataSessao { get; set; }
    }
}
