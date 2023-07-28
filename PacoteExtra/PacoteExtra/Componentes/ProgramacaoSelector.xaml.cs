using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace PacoteExtra.Componentes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramacaoSelector : ContentView
    {
        private string _primeiroDia;

        public static readonly BindableProperty ProgramacoesProperty = BindableProperty.Create(nameof(Programacoes), typeof(List<ProgramacaoModel>), typeof(DateTimeLineSwippe), null);
        public List<ProgramacaoModel> Programacoes
        {
            get { return (List<ProgramacaoModel>)GetValue(ProgramacoesProperty); }
            set { SetValue(ProgramacoesProperty, value); }
        }

        public static readonly BindableProperty SessaoSelectedProperty = BindableProperty.Create(nameof(SessaoSelected), typeof(ICommand), typeof(DateTimeLineSwippe), null);
        public ICommand SessaoSelected
        {
            get { return (ICommand)GetValue(SessaoSelectedProperty); }
            set { SetValue(SessaoSelectedProperty, value);}
        }


        public ProgramacaoSelector()
        {
            InitializeComponent();
            DiasView.DataInicio = DateTime.Now;
            DiasView.DataFim = DateTime.Now.AddDays(15);
            DiasView.AoSelecionarCommand = new Command((e) => { SelecaoDeDiaEvento(e); });
         //   ListaProgramacao.AoPressionar = new Command((a) => { B(a); });
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == nameof(Programacoes))
            {
                ListaProgramacao.ItensOrigem = MonteUmaListasDoDia(DiasView.DataInicio.ToString("dd/MM"));
            }
        }

        private List<CollectionViewModel> MonteUmaListasDoDia(string DiaSelecionado)
        {
            var filmesCollections = new List<CollectionViewModel>();
            foreach (var programacao in Programacoes)
            {
                var programacaoCollectionViewModel = new CollectionViewModel();
                var filme = programacao.Filme;
                programacaoCollectionViewModel.Titulo = filme.NomeFilme;
                programacaoCollectionViewModel.Descricao = filme.UrlImagem;
                programacaoCollectionViewModel.PropriedadeEmlista = new List<CollectionViewModel>()
                {
                    new CollectionViewModel()
                    {
                        Descricao = filme.Classificacao.Abreviacao,
                        CorElemento = filme.Classificacao.CorClassificacao
                    },
                     new CollectionViewModel()
                    {
                        Descricao = "Dublado",
                        CorElemento = Color.Transparent
                    }
                };
                programacaoCollectionViewModel.PropriedadeEmlista2 = new List<CollectionViewModel>();
                foreach (var sessao in programacao.Sessao)
                {
                    if (sessao.DataSessao.ToString("dd/MM") == DiaSelecionado)
                    {
                        programacaoCollectionViewModel.PropriedadeEmlista2.Add(new CollectionViewModel()
                        {
                            Id = sessao.Codigo,
                            Descricao = sessao.DataSessao.ToString("HH:mm"),
                        }); 
                    }
                }

                if (programacaoCollectionViewModel.PropriedadeEmlista2.Any())
                {
                    programacaoCollectionViewModel.PropriedadeEmListaToque = new Command((e) => {
                        Sessaotapped(e);
                    });
                    filmesCollections.Add(programacaoCollectionViewModel);
                }
            }
            return filmesCollections.Any() ? filmesCollections : null;
        }


        private void Sessaotapped(object e)
        {
            if(SessaoSelected?.CanExecute(e) ?? false) { 
                SessaoSelected.Execute(e);
            }
        }

        private void SelecaoDeDiaEvento(object e)
        {
            if (e is CollectionViewModel teste)
            {
                ListaProgramacao.ItensOrigem = MonteUmaListasDoDia(teste.Descricao);
            }

        }
    }
}