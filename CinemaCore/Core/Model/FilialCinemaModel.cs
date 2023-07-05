using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaCore.Core.Model
{
    public class FilialCinemaModel
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Distancia { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        
    }
}
