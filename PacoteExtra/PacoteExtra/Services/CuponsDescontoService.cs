using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PacoteExtra.Core.Services
{
    public class CuponsDescontoService
    {
        private readonly ICuponsRepository _cupomRepository = DependencyService.Resolve<ICuponsRepository>();
        public Task<List<CuponsModel>> ObtenhaDescontosDaFilial(int codigo)
        {
            return _cupomRepository.ObtenhaCuponsDescontoPorFilial(codigo);
        }
    }
}
