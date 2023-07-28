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
    public partial class DropDown : ContentView
    {
        public static BindableProperty ClickComandProperty = BindableProperty.Create(nameof(ClickComand), typeof(ICommand), typeof(DropDown), null);
        public static BindableProperty DescricaoProperty = BindableProperty.Create(nameof(Descricao), typeof(string), typeof(DropDown), null);
        public static BindableProperty TituloProperty = BindableProperty.Create(nameof(Titulo), typeof(string), typeof(DropDown), null);
        public static BindableProperty CorDeFundoProperty = BindableProperty.Create(nameof(CorDeFundo), typeof(Color), typeof(DropDown), null);
        public static BindableProperty PaddingTextoDropDownProperty = BindableProperty.Create(nameof(PaddingTextoDropDown), typeof(Thickness), typeof(DropDown), null);

        public Thickness PaddingTextoDropDown
        {
            get { return (Thickness)GetValue(PaddingTextoDropDownProperty); }
            set { SetValue(PaddingTextoDropDownProperty, value); }
        }

        public Color CorDeFundo
        {
            get { return (Color)GetValue(CorDeFundoProperty); }
            set { SetValue(CorDeFundoProperty, value); }
        }

        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }
        public string Descricao
        {
            get { return (string)GetValue(DescricaoProperty); }
            set { SetValue(DescricaoProperty, value); }
        }
        public ICommand ClickComand
        {
            get { return (ICommand)GetValue(ClickComandProperty); }
            set { SetValue(ClickComandProperty, value); }
        }
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == nameof(Titulo))
            {
                LabelTitulo.Text = Titulo;
            }
            if (propertyName == nameof(CorDeFundo))
            {
                Frame.BackgroundColor = CorDeFundo;
            }
            if (propertyName == nameof(PaddingTextoDropDown))
            {
                DropDownStack.Padding = PaddingTextoDropDown;
            }
            if (propertyName == nameof(Descricao))
            {
                LabelDescricao.Text = Descricao;
            }
        }
        public DropDown()
        {
            InitializeComponent();
        }
        private void ClickDoDropDown(object sender, EventArgs e)
        {
            if (ClickComand?.CanExecute(null) ?? false)
            {
                ClickComand.Execute(this);
            }
        }
    }
}