using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PacoteExtra.Models
{
    public class IngressoAppModel
    {
        public int Codigo { get; set; }
        public FilmeModel Filme { get; set; }
        public SessaoModel Sessao { get; set; }
        public FilialCinemaModel FilialCinema { get; set; }
        public List<PoltronaModel> Poltronas { get; private set; }
        public IngressoAppModel()
        {
            Poltronas = new List<PoltronaModel>();
        }
    }
}
