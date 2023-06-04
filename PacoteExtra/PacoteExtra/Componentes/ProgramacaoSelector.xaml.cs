using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PacoteExtra.Componentes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProgramacaoSelector : ContentView
	{
        public ProgramacaoSelector()
        {
            InitializeComponent();
            DiasView.DataInicio = DateTime.Now;
            DiasView.DataFim = DateTime.Now.AddDays(15);
            DiasView.AoSelecionarCommand = new Command(() => { SelecaoDeDiaEvento(); });
            ListaProgramacao.AoPressionar = new Command((a) => { B(a); });
            ListaProgramacao.ItensOrigem = MonteUmaLista(1);
		}

        private void C(object objeto)
        {
        }

        private List<CollectionViewModel> MonteUmaLista(int opcao)
        {
            var shoppings = new List<CollectionViewModel>();
            if(opcao == 1){
                shoppings.Add(new CollectionViewModel
                {
                    Titulo = "Cineflix aparecida de goiânia",
                    Descricao = "https://i0.wp.com/animagos.com.br/wp-content/uploads/2019/01/DVD-COG-v1.png?resize=759%2C1080",
                    Descricao1 = "A, B e C",
                    Descricao2 = "Aparecida de goiania - Go",
                    PropriedadeEmlista = new List<CollectionViewModel>() { new CollectionViewModel() { Descricao = "18", CorElemento = "#362120" }, new CollectionViewModel() { Descricao = "3D", CorElemento = "#1b291c" } },
                    PropriedadeEmListaToque = new Command((x) => { C(x); }),
                    PropriedadeEmlista2 = new List<CollectionViewModel>() { new CollectionViewModel() { Descricao = "07:00" }, new CollectionViewModel() { Descricao = "12:00" }, new CollectionViewModel() { Descricao = "17:00" } },
                    PropriedadeEmListaToque2 = new Command((x) => { D(x); })
                });
                shoppings.Add(new CollectionViewModel
                {
                    Titulo = "Cineflix Shopping Sul - Valparaiso",
                    Descricao = "2,94 KM",
                    Descricao1 = "Rod BR 040",
                    Descricao2 = "Valparaíso de Goias - Go",
                    PropriedadeEmlista = new List<CollectionViewModel>() { new CollectionViewModel() { Descricao = "18", CorElemento = "#362120" }, new CollectionViewModel() { Descricao = "3D", CorElemento = "#1b291c" }  },
                    PropriedadeEmListaToque = new Command((x) => { C(x); }),
                    PropriedadeEmlista2 = new List<CollectionViewModel>() { new CollectionViewModel() { Descricao = "07:00" }, new CollectionViewModel(){ Descricao = "12:00" } },
                    PropriedadeEmListaToque2 = new Command((x) => { D(x); })
                }); ;
                return shoppings;
            }
            else
            {
                shoppings.Add(new CollectionViewModel
                {
                    Titulo = "Cineflix Shopping Sul - Valparaiso",
                    Descricao = "2,94 KM",
                    Descricao1 = "Rod BR 040",
                    Descricao2 = "Valparaíso de Goias - Go",
                    PropriedadeEmlista = new List<CollectionViewModel>() { new CollectionViewModel() { Descricao = "18", CorElemento = "#362120" }, new CollectionViewModel() { Descricao = "3D",CorElemento = "#1b291c" } },
                    PropriedadeEmListaToque = new Command((x) => { C(x); }),
                    PropriedadeEmlista2 = new List<CollectionViewModel>() { new CollectionViewModel() { Descricao = "29:45"} },
                    PropriedadeEmListaToque2 = new Command((x) => { D(x); })
                });
                return shoppings;
            }
        }

        private void D(object x)
        {
            throw new NotImplementedException();
        }

        private Action<object> B(object e)
        {
            return null;
        }

        private void SelecaoDeDiaEvento()
        {
            ListaProgramacao.ItensOrigem = MonteUmaLista(2);
        }
    }
}