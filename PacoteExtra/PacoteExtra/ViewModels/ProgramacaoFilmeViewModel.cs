using CinemaCore.Core.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PacoteExtra.Componentes;
using PacoteExtra.Core.Services;
using PacoteExtra.Core.Util;
using PacoteExtra.Models;
using PacoteExtra.Views.BuscaShopping;
using PacoteExtra.Views.CompraTicket;
using PacoteExtra.Views.ProgrtamacaoDeFilme;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PacoteExtra.ViewModels
{
    [ObservableObject]
    public partial class ProgramacaoFilmeViewModel : BaseViewModel
    {
        public ProgramacaoFilmeViewModel()
        {
            DescricaoLeiaOculte = "Leia mais";

        }
        private readonly ShoppingService _filialService = new ShoppingService();
        private readonly FilmeService _filmeService = new FilmeService();
        private readonly ProgramacaoService _programacaoService = new ProgramacaoService();
        private int _codigoFilme;

        [ObservableProperty]
        FilialCinemaModel filialSelecionada;
        [ObservableProperty]
        bool ehFavorito;
        [ObservableProperty]
        FilmeViewModel filmeModel;
        [ObservableProperty]
        List<ProgramacaoModel> programacao;
        [ObservableProperty]
        bool maisDetalhesVisible;
        [ObservableProperty]
        string descricaoLeiaOculte;

        [RelayCommand]
        void ClipClick()
        {

        }

        [RelayCommand]
        async void AdicioneAosfavorios()
        {
            if (EhFavorito)
            {
                await _filmeService.AdicioneAosFavoritos(_codigoFilme);
            }
            else
            {
                await _filmeService.Removafavorito(_codigoFilme);
            }
        }

        [RelayCommand]
        async void Voltar()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }

        [RelayCommand]
        void LeiaMais()
        {
            MaisDetalhesVisible = !MaisDetalhesVisible;
            DescricaoLeiaOculte = MaisDetalhesVisible ? "Ocultar detalhes" : "Mais detalhes";
        }

        [RelayCommand]
        async void TrocarFilial()
        {
            await App.Current.MainPage.Navigation.PushAsync(new BuscaShoppingPage());
        }

        [RelayCommand]
        void DiaSelecionado(object dia)
        {

        }

        [RelayCommand]
        void SessaoSelected(object horario)
        {
            App.Current.MainPage.Navigation.PushAsync(new CompraTicketPage());
        }

        public override async void EventoAoAparecer()
        {
            base.EventoAoAparecer();
            await Carregando.CarregueEnquandoAcaoEstiverRodando(async () =>
            {
                var parametro = (CollectionViewModel)SingletonParametros.GetInstance().GetParametros(nameof(ProgramacaoFilme));
                _codigoFilme = parametro?.Id ?? _codigoFilme;
                var filial = await _filialService.ObtenhaUltimaFiliaBuscada();
                EhFavorito = await _filmeService.FilmeEhFavorito(_codigoFilme);
                var filme = await _filmeService.ObtenhaDadosDoFilme(_codigoFilme);
                var programacaoFilme = await _programacaoService.Obtenhaprogramacao(filme, filial, DateTime.Now, DateTime.Now.AddDays(15));

                Device.BeginInvokeOnMainThread(() =>
                {

                    FilmeModel = MeuMapper.Mapper.Mapeamento.Map<FilmeViewModel>(filme);
                    FilialSelecionada = filial;
                    Programacao = new List<ProgramacaoModel>() { programacaoFilme };
                });

            }, "Carregando dados do Filme");
        }
    }
}
