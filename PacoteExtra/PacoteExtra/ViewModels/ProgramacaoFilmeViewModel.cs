using AutoMapper;
using CinemaCore.Core.Model;
using CinemaCore.Core.Servico;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PacoteExtra.Componentes;
using PacoteExtra.Core.Util;
using PacoteExtra.Models;
using PacoteExtra.Views.BuscaShopping;
using PacoteExtra.Views.ProgrtamacaoDeFilme;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PacoteExtra.ViewModels
{
    [ObservableObject]
    public partial class ProgramacaoFilmeViewModel : BaseViewModel
    {
        private readonly ShoppingService _filialService = new ShoppingService();
        private readonly FilmeService _filmeService = new FilmeService();
        private int _codigoFilme;

        [ObservableProperty]
        FilialCinemaModel filialSelecionada;
        [ObservableProperty]
        bool ehFavorito;
        [ObservableProperty]
        FilmeViewModel filmeModel;

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
        void LeiaMaisComenad()
        {

        }

        [RelayCommand]
        async void TrocarFilial()
        {
            await App.Current.MainPage.Navigation.PushAsync(new BuscaShoppingPage());
        }

        [RelayCommand]
        void DiaSelecionadoComand(object dia)
        {

        }

        [RelayCommand]
        void SessaoSelected(object horario)
        {

        }

        public override async void EventoAoAparecer()
        {
            base.EventoAoAparecer();
            await Carregando.CarregueEnquandoAcaoEstiverRodando(async () =>
            {
                var parametro = (CollectionViewModel)SingletonParametros.GetInstance().GetParametros(nameof(programacaoFilme));
                _codigoFilme = parametro.Id;
                var filial = await _filialService.ObtenhaUltimaFiliaBuscada();
                EhFavorito = await _filmeService.FilmeEhFavorito(_codigoFilme);
                var filme = await _filmeService.ObtenhaDadosDoFilme(_codigoFilme);
                Device.BeginInvokeOnMainThread(() =>
                {

                    FilmeModel = MeuMapper.Mapper.Mapeamento.Map<FilmeViewModel>(filme);
                    FilialSelecionada = filial;
                });
            }, "Carregando dados do Filme");
        }
    }
}
