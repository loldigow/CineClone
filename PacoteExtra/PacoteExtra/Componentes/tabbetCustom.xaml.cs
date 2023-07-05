using PacoteExtra.Core.Enum;
using PacoteExtra.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PacoteExtra.Componentes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class tabbetCustom : ContentView
    {
        public static readonly BindableProperty SelectedIndexProperty = BindableProperty.Create(nameof(SelectedIndex), typeof(int), typeof(tabbetCustom), null);
        public static readonly BindableProperty TapChangedProperty = BindableProperty.Create(nameof(TapChanged), typeof(ICommand), typeof(tabbetCustom), null);
        public int SelectedIndex
        {
            get { return (int)GetValue(SelectedIndexProperty); }
            set { SetValue(SelectedIndexProperty, value); }
        }
        public ICommand TapChanged
        {
            get { return (ICommand)GetValue(TapChangedProperty); }
            set { SetValue(TapChangedProperty, value); }
        }

        public tabbetCustom()
        {
            InitializeComponent();
            SelectedIndex = 1;
            Tabb1.TextColor = Color.Yellow;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (e != null && e is TappedEventArgs evento)
            {
                var parametro = (TappedEnum)evento.Parameter;
                Invoke(TapChanged, (int)parametro);
            }
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == nameof(SelectedIndex))
            {
                Invoke(TapChanged, SelectedIndex);
            }
        }

        private void Invoke(ICommand command, int v)
        {
            SelectTab(v);
            if (command?.CanExecute(v) ?? false)
            {
                command.Execute(v);
            }

        }

        private void SelectTab(int tab)
        {
            DesselecioneTodasTabs();
            LabelAwesome label = null;
            switch(tab)
            {
                case 1:
                    label = Tabb1;
                    break;
                case 2:
                    label = Tabb2;
                    break;
                case 3:
                    label = Tabb3;
                    break;
                default:
                    label = Tabb4;
                    break;
            }
            label.TextColor = Color.Yellow;
            label.BackgroundColor = Color.FromHex("#18202b");
            SelectedIndex = tab;
        }

        private void DesselecioneTodasTabs()
        {
            Tabb1.TextColor = Color.White;
            Tabb2.TextColor = Color.White;
            Tabb3.TextColor = Color.White;
            Tabb4.TextColor = Color.White;

            Tabb1.BackgroundColor = Color.FromHex("#293649");
            Tabb2.BackgroundColor = Color.FromHex("#293649");
            Tabb3.BackgroundColor = Color.FromHex("#293649");
            Tabb4.BackgroundColor = Color.FromHex("#293649");
        }
    }
}