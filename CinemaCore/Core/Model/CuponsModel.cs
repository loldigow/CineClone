using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaCore.Core.Model
{
    public class CuponsModel
    {
        public int Codigo { get; set; }
        public int Filial { get; set; }
        public decimal ProcentagemDesconto { get; set; }
        public string CodigoDesconto { get; set; }
        public string DescricaoDesconto { get; set; }
        public string RegraDesconto { get; set; }
    }
}
