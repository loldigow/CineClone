using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PacoteExtra.ViewModels;
using PacoteExtra.Views.BuscaShopping;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PacoteExtra.Componentes
{
    
    public partial class InicioViewModel
    {
       
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VisualizadorProgramacaoCompleta : ContentView
    {
        public VisualizadorProgramacaoCompleta()
        {
            InitializeComponent();
            BindingContext = new InicioViewModel();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
        }
    }
}
