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
    public partial class BotaoFacil : ContentView
    {
        public static readonly BindableProperty AoPressionarProperty = BindableProperty.Create(nameof(AoPressionar), typeof(ICommand), typeof(DropDown), null);
        public static readonly BindableProperty TextoProperty = BindableProperty.Create(nameof(Texto), typeof(string), typeof(DropDown), null);
        public static readonly BindableProperty ObjetoProperty = BindableProperty.Create(nameof(Objeto), typeof(object), typeof(DropDown), null);
        public static readonly BindableProperty CorBordaProperty = BindableProperty.Create(nameof(CorBorda), typeof(Color), typeof(DropDown), null);

        public ICommand AoPressionar
        {
            get { return (ICommand)GetValue(AoPressionarProperty); }
            set { SetValue(AoPressionarProperty, value); }
        }
        public Color CorBorda
        {
            get { return (Color)GetValue(CorBordaProperty); }
            set { SetValue(CorBordaProperty, value); }
        }
        public string Texto
        {
            get { return (string)GetValue(TextoProperty); }
            set { SetValue(TextoProperty, value); }
        }
        public object Objeto
        {
            get { return (string)GetValue(ObjetoProperty); }
            set { SetValue(ObjetoProperty, value); }
        }
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == nameof(CorBorda))
            {
                Botao.BorderColor = CorBorda;
                Botao.BorderWidth = 1;
            }
            if (propertyName == nameof(Texto))
            {
                Botao.Text = Texto;
            }
        }
        public BotaoFacil()
        {
            InitializeComponent();
        }

        private void BotaoPressionado(object sender, EventArgs e)
        {
            if (AoPressionar?.CanExecute(Objeto) ?? false)
            {
                AoPressionar.Execute(Objeto);
            }
        }
    }
}