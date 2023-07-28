using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaCore.Core.Model
{
    public class IngressoModel
    {
        public int Codigo { get; set; }
        public int Filme { get; set; }
        public int Sessao { get; set; }
        public int FilialCinema { get; set;}
        public List<int> Poltronas { get; set; }
        public IngressoModel()
        {
            Poltronas = new List<int>();            
        }
    }
}
