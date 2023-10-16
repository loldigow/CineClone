using System;
using System.Collections.Generic;
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
    public partial class PoltronaComponente : ContentView
    {
        public static readonly BindableProperty DescricaoPoltronaProperty = BindableProperty.Create(nameof(DescricaoPoltrona), typeof(string), typeof(PoltronaComponente), null);
        public static readonly BindableProperty OcupadoProperty = BindableProperty.Create(nameof(Ocupado), typeof(bool), typeof(PoltronaComponente), null);
        public static readonly BindableProperty SelecaoProperty = BindableProperty.Create(nameof(Selecao), typeof(bool), typeof(PoltronaComponente), null);
        public static readonly BindableProperty SelecaoCommandProperty = BindableProperty.Create(nameof(SelecaoCommand), typeof(ICommand), typeof(PoltronaComponente), null);
        public string DescricaoPoltrona
        {
            get { return GetValue(DescricaoPoltronaProperty) as string; }
            set { SetValue(DescricaoPoltronaProperty, value); }
        }

        public bool Ocupado
        {
            get { return (bool)GetValue(OcupadoProperty); }
            set { SetValue(OcupadoProperty, value); }
        }

        public bool Selecao
        {
            get { return (bool)GetValue(SelecaoProperty); }
            set { SetValue(SelecaoProperty, value); }
        }

        public ICommand SelecaoCommand
        {
            get { return (ICommand)GetValue(SelecaoCommandProperty); }
            set { SetValue(SelecaoCommandProperty, value); }
        }

        public PoltronaComponente()
        {
            InitializeComponent();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if(nameof(DescricaoPoltrona) == propertyName)
            {
                PoltronaNome.Text = DescricaoPoltrona;
            }
            if(nameof(Selecao) == propertyName)
            {
                AjusteFrame();
            }
            if(nameof(Ocupado) == propertyName)
            {
                PoltronaFrame.BackgroundColor = Color.Red;
                PoltronaNome.TextColor = Color.White;
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if(!Ocupado)
            {
                Selecao = !Selecao;
                if(SelecaoCommand.CanExecute(DescricaoPoltrona))
                {
                    SelecaoCommand.Execute(DescricaoPoltrona);
                }
            }
        }

        private void AjusteFrame()
        {
            var corTexto = Selecao ? Color.White : Color.Black;
            var corBackGround = Selecao ? Color.Green : Color.White;
            PoltronaFrame.BackgroundColor = corBackGround;
            PoltronaNome.TextColor = corTexto;
        }
    }
}