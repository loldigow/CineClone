using PacoteExtra.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PacoteExtra.Componentes.ExemplosDeUso.Loading
{
    public class LoadingMVVM : BaseViewModel
    {
        public LoadingMVVM() { }

        public override async void EventoAoAparecer()
        {
            base.EventoAoAparecer();
            await Task.Delay(5000);
            await Carregando.CarregueEnquandoAcaoEstiverRodando(async () =>
            {
                var teste = 2;
                await Task.Delay(2000);
                teste = 3;
            }, "Carregando");
        }
    }
}
