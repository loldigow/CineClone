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
    public partial class EntryCustom : ContentView
    {
        public static readonly BindableProperty TextoDescricaoProperty = BindableProperty.Create(nameof(TextoDescricao), typeof(string), typeof(DropDown), null);
        public static readonly BindableProperty EntryEnabledProperty = BindableProperty.Create(nameof(EntryEnabled), typeof(bool), typeof(DropDown), null);
        public static readonly BindableProperty TextoProperty = BindableProperty.Create(nameof(Texto), typeof(string), typeof(DropDown), null);
        public static readonly BindableProperty CorBordaProperty = BindableProperty.Create(nameof(CorBorda), typeof(Color), typeof(DropDown), null);
        public static readonly BindableProperty AoMudarTextoProperty = BindableProperty.Create(nameof(AoMudarTexto), typeof(ICommand), typeof(DropDown), null);
        public string TextoDescricao
        {
            get { return (string)GetValue(TextoDescricaoProperty); }
            set { SetValue(TextoDescricaoProperty, value); }
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

        public ICommand AoMudarTexto
        {
            get { return (ICommand)GetValue(AoMudarTextoProperty); }
            set { SetValue(AoMudarTextoProperty, value); }
        }

        public bool EntryEnabled
        {
            get { return (bool)GetValue(EntryEnabledProperty); }
            set { SetValue(EntryEnabledProperty, value); }
        }
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == nameof(CorBorda))
            {
                PancakeFrame.Border.Color = CorBorda;
            }
            if (propertyName == nameof(Texto))
            {
                Editor.Text = Texto;
            }
            if (propertyName == nameof(EntryEnabled))
            {
                Editor.IsEnabled = EntryEnabled;
            }
            if (propertyName == nameof(TextoDescricao))
            {
                LabelText.Text = TextoDescricao;
            }
        }
        public EntryCustom()
        {
            InitializeComponent();
            Editor.Focused += TextFocus;
            Editor.Unfocused += TextUnfocus;
        }
        private void TextUnfocus(object sender, FocusEventArgs e)
        {
            if (string.IsNullOrEmpty(Editor.Text))
                LabelText.FontSize = (double)new FontSizeConverter().ConvertFromInvariantString("Medium");
        }

        private void TextFocus(object sender, FocusEventArgs e)
        {
            LabelText.FontSize = (double)new FontSizeConverter().ConvertFromInvariantString("Small");
        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            Texto = e.NewTextValue;
            if (AoMudarTexto?.CanExecute(null) ?? false)
            {
                AoMudarTexto.Execute(null);
            }
        }
    }
}