using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PacoteExtra.Componentes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DateTimeLineSwippe : ContentView
    {
        public static readonly BindableProperty DataInicioProperty = BindableProperty.Create(nameof(DataInicio), typeof(DateTime), typeof(DateTimeLineSwippe), null);
        public static readonly BindableProperty DataFimProperty = BindableProperty.Create(nameof(DataFim), typeof(DateTime), typeof(DateTimeLineSwippe), null);
        public static readonly BindableProperty AoSelecionarCommandProperty = BindableProperty.Create(nameof(AoSelecionarCommand), typeof(ICommand), typeof(DateTimeLineSwippe), null);
        public DateTime DataInicio
        {
            get { return (DateTime)GetValue(DataInicioProperty); }
            set { SetValue(DataInicioProperty, value); }
        }
        public ICommand AoSelecionarCommand
        {
            get { return (ICommand)GetValue(AoSelecionarCommandProperty); }
            set { SetValue(AoSelecionarCommandProperty, value); }
        }
        public DateTime DataFim
        {
            get { return (DateTime)GetValue(DataFimProperty); }
            set { SetValue(DataFimProperty, value); }
        }
        public DateTimeLineSwippe()
        {
            InitializeComponent();
            ListaDias.AoPressionar = new Command(execute: (e) => ExecuteNaSelecao(e));
            CarregueItens();
        }
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == nameof(DataInicio) || propertyName == nameof(DataFim))
            {
                CarregueItens();
            }
        }
        public void ExecuteNaSelecao(object objeto)
        {
            if (objeto is CollectionViewModel item)
            {
                foreach (var dia in ListaDias.ItemsSource)
                {
                    var diaModel = (CollectionViewModel)dia;
                    diaModel.CorElemento = item == dia ? Xamarin.Forms.Color.FromHex("#FFFFFF") : Xamarin.Forms.Color.FromHex("#949aa3");
                }
                if (AoSelecionarCommand?.CanExecute(item) ?? false)
                {
                    AoSelecionarCommand.Execute(item);
                }
            }
        }

        private void CarregueItens()
        {
            if (DataInicio != DateTime.MinValue && DataFim != DateTime.MinValue)
            {
                var dias = new List<CollectionViewModel>();
                var inicio = DataInicio;
                var fim = DataFim;
                for (int i = 0; inicio.AddDays(i) <= fim; i++)
                {
                    dias.Add(new CollectionViewModel
                    {
                        Id = i,
                        CorElemento = i == 0 ? Xamarin.Forms.Color.FromHex("#FFFFFF") : Xamarin.Forms.Color.FromHex("#949aa3"),
                        Titulo = inicio.AddDays(i).ToString("ddd", CultureInfo.CurrentCulture),
                        Descricao = inicio.AddDays(i).ToString("dd/MM")
                    });
                }
                ListaDias.ItensOrigem = dias;
                ExecuteNaSelecao(dias.FirstOrDefault());
            }
        }
    }
}