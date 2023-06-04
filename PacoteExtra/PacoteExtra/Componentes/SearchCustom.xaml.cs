using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.Permissions;

namespace PacoteExtra.Componentes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchCustom : ContentView
    {
        public static BindableProperty TextoBuscaProperty;
        public static BindableProperty AtualizeCommandProperty;
        public string TextoBusca
        {
            get { return (string)GetValue(TextoBuscaProperty); }
            set { SetValue(TextoBuscaProperty, value); }
        }
        public ICommand AtualizeCommand
        {
            get { return (ICommand)GetValue(AtualizeCommandProperty); }
            set { SetValue(AtualizeCommandProperty, value); }
        }
        public SearchCustom()
        {
            InitializeComponent();
            TextoBuscaProperty = BindableProperty.Create(nameof(TextoBusca), typeof(string), typeof(DropDown), null);
            AtualizeCommandProperty = BindableProperty.Create(nameof(AtualizeCommand), typeof(ICommand), typeof(DropDown), null);
            EntryPesquisa.AoMudarTexto = new Command(AcioneEventoAtualizacaoDeDados);

        }

        private void AcioneEventoAtualizacaoDeDados(object obj)
        {
            if(AtualizeCommand?.CanExecute(EntryPesquisa.Texto) ?? false)
            {
                AtualizeCommand.Execute(EntryPesquisa.Texto);
            }
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if(propertyName == nameof(TextoBusca))
            {
                EntryPesquisa.TextoDescricao = TextoBusca;
            }
        }

        private void NoClickDaLupa(object sender, EventArgs e)
        {
            AcioneEventoAtualizacaoDeDados(null);
        }
    }
}