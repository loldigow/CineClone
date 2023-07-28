using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock.Repository
{
    public class CuponsMock : ICuponsRepository
    {
        private List<CuponsModel> _cupons = new List<CuponsModel> ();
        public CuponsMock()
        {
            _cupons.Add(new CuponsModel() { Codigo = 1 , Filial = 1, CodigoDesconto = "Love", DescricaoDesconto = "Para os amantes neste dia dos namorados", ProcentagemDesconto=50,RegraDesconto="Deconto valido somente para compra de 2 ingressos"});
            _cupons.Add(new CuponsModel() { Codigo = 2 , Filial = 1, CodigoDesconto = "Best", DescricaoDesconto = "Para voce que ama o seu amigo", ProcentagemDesconto=25,RegraDesconto="Deconto valido somente para compra de 2 ingressos"});
            _cupons.Add(new CuponsModel() { Codigo = 3 , Filial = 1, CodigoDesconto = "WeLoveKids", DescricaoDesconto = "Dia das crinças é bom d+", ProcentagemDesconto=80,RegraDesconto="Deconto valido para adultos acompanhados de crianças menores de 12 anos"});
            _cupons.Add(new CuponsModel() { Codigo = 4 , Filial = 1, CodigoDesconto = "CinemaEBomD+", DescricaoDesconto = "nem todo inicio de semana são os piores", ProcentagemDesconto=25,RegraDesconto="Deconto valido para segundas terças e quartas"});

            _cupons.Add(new CuponsModel() { Codigo = 5, Filial = 2, CodigoDesconto = "Love", DescricaoDesconto = "Para os amantes neste dia dos namorados", ProcentagemDesconto = 50, RegraDesconto = "Deconto valido somente para compra de 2 ingressos" });
            _cupons.Add(new CuponsModel() { Codigo = 6, Filial = 2, CodigoDesconto = "Best", DescricaoDesconto = "Para voce que ama o seu amigo", ProcentagemDesconto = 25, RegraDesconto = "Deconto valido somente para compra de 2 ingressos" });
            _cupons.Add(new CuponsModel() { Codigo = 7, Filial = 2, CodigoDesconto = "WeLoveKids", DescricaoDesconto = "Dia das crinças é bom d+", ProcentagemDesconto = 80, RegraDesconto = "Deconto valido para adultos acompanhados de crianças menores de 12 anos" });
            _cupons.Add(new CuponsModel() { Codigo = 8, Filial = 2, CodigoDesconto = "CinemaEBomD+", DescricaoDesconto = "nem todo inicio de semana são os piores", ProcentagemDesconto = 25, RegraDesconto = "Deconto valido para segundas terças e quartas" });
            _cupons.Add(new CuponsModel() { Codigo = 9, Filial = 2, CodigoDesconto = "AdoroMinhaCidade", DescricaoDesconto = "Vamos sair pois na minha cidade é motivo de festejar", ProcentagemDesconto = 25, RegraDesconto = "Deconto valido somente no dia do aniversário desta cidade" });

            _cupons.Add(new CuponsModel() { Codigo = 10, Filial = 3, CodigoDesconto = "Love", DescricaoDesconto = "Para os amantes neste dia dos namorados", ProcentagemDesconto = 50, RegraDesconto = "Deconto valido somente para compra de 2 ingressos" });
            _cupons.Add(new CuponsModel() { Codigo = 11 ,Filial = 3, CodigoDesconto = "CinemaEBomD+", DescricaoDesconto = "nem todo inicio de semana são os piores", ProcentagemDesconto = 25, RegraDesconto = "Deconto valido para segundas terças e quartas" });
           
            _cupons.Add(new CuponsModel() { Codigo = 12 ,Filial = 5, CodigoDesconto = "CinemaEBomD+", DescricaoDesconto = "nem todo inicio de semana são os piores", ProcentagemDesconto = 25, RegraDesconto = "Deconto valido para segundas terças e quartas" });
        }
        public async Task<List<CuponsModel>> ObtenhaCuponsDescontoPorFilial(int codigoFilial)
        {
            await Task.Delay(150);
            return _cupons.Where(x=> x.Filial == codigoFilial).ToList();
        }
    }
}
