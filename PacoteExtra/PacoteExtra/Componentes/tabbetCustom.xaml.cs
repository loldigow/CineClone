using PacoteExtra.Core.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
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
        public static readonly BindableProperty Tapped1ComandProperty = BindableProperty.Create(nameof(Tapped1Comand), typeof(ICommand), typeof(tabbetCustom), null);
        public static readonly BindableProperty Tapped2ComandProperty = BindableProperty.Create(nameof(Tapped2Comand), typeof(ICommand), typeof(tabbetCustom), null);
        public static readonly BindableProperty Tapped3ComandProperty = BindableProperty.Create(nameof(Tapped3Comand), typeof(ICommand), typeof(tabbetCustom), null);
        public static readonly BindableProperty Tapped4ComandProperty = BindableProperty.Create(nameof(Tapped4Comand), typeof(ICommand), typeof(tabbetCustom), null);
        public int SelectedIndex
        {
            get { return (int)GetValue(SelectedIndexProperty); }
            set { SetValue(SelectedIndexProperty, value); }
        }
        public ICommand Tapped1Comand
        {
            get { return (ICommand)GetValue(Tapped1ComandProperty); }
            set { SetValue(Tapped1ComandProperty, value); }
        }
        public ICommand Tapped2Comand
        {
            get { return (ICommand)GetValue(Tapped2ComandProperty); }
            set { SetValue(Tapped2ComandProperty, value); }
        }
        public ICommand Tapped3Comand
        {
            get { return (ICommand)GetValue(Tapped3ComandProperty); }
            set { SetValue(Tapped3ComandProperty, value); }
        }
        public ICommand Tapped4Comand
        {
            get { return (ICommand)GetValue(Tapped4ComandProperty); }
            set { SetValue(Tapped4ComandProperty, value); }
        }


        public tabbetCustom ()
		{
			InitializeComponent ();
            SelectedIndex = 1;
            Tabb1.TextColor = Color.Yellow;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if(e != null && e is TappedEventArgs evento)
            {
                var parametro = (TappedEnum)evento.Parameter;
                switch(parametro)
                {
                    case TappedEnum.T1:
                        Invoke(Tabb1, Tapped1Comand,1);
                        break;
                    case TappedEnum.T2:
                        Invoke(Tabb2, Tapped2Comand,2);
                        break;
                    case TappedEnum.T3:
                        Invoke(Tabb3, Tapped3Comand,3);
                        break;
                    case TappedEnum.T4:
                        Invoke(Tabb4, Tapped4Comand,4);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Invoke(LabelAwesome tabb1, ICommand command, int v)
        {
            Tabb1.TextColor = Color.White;
            Tabb2.TextColor = Color.White;
            Tabb3.TextColor = Color.White;
            Tabb4.TextColor = Color.White;

            tabb1.TextColor = Color.Yellow;
            SelectedIndex = v;
            if( command?.CanExecute(v) ?? false)
            {
                command.Execute(v);
            }

        }
    }
}