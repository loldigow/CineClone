using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PacoteExtra.Componentes;
using PacoteExtra.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PacoteExtra.ViewModels
{
    [ObservableObject]
    internal partial class MeusIngressosViewModel : BaseViewModel
    {
        private readonly IngressosService _historicoIngressos = new IngressosService();
        [ObservableProperty]
        List<CollectionViewModel> ingressosVencidos;
        public override async void EventoAoAparecer()
        {
            await Carregando.CarregueEnquandoAcaoEstiverRodando(async () =>
            {
                await CarregueIngressosAntigos();

            }, "Carregando lista de ingressos");
        }

        private async Task CarregueIngressosAntigos()
        {
            var ultimasCompras = await _historicoIngressos.ObtenhaUltimosIngressosDaFilial();
            var ingressosConvertidos = ultimasCompras.Select(x => new CollectionViewModel()
            {
                Id = x.Codigo,
                Titulo = x.Filme.NomeFilme,
                Descricao = x.Sessao.DescricaoSessao,
                Descricao1 = x.Sessao.DataSessao.ToString("HH:mm"),
                Descricao2 = string.Join(", ", x.Poltronas.Select(x => x.Descricao)),
                Descricao3 = x.Sessao.DataSessao.ToString("dd/MM/yyyy"),
                Descricao4 = x.FilialCinema.Descricao
            }).ToList();
            Device.BeginInvokeOnMainThread(() =>
            {
                IngressosVencidos = ingressosConvertidos;
            });
        }

        [RelayCommand]
        async void Voltar()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
