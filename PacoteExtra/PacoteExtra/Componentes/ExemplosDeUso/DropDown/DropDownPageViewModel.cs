using CommunityToolkit.Mvvm.Input;
using PacoteExtra.Models;
using PacoteExtra.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PacoteExtra.Componentes.ExemplosDeUso.DropDown
{
    public partial class DropDownPageViewModel : BaseViewModel
    {
        public string TituloDropDown { get; set; }

        
        public string DescricaoDropDown { get; set; }

        public DropDownPageViewModel()
        {
            TituloDropDown = "Aparecida Shopping";
            DescricaoDropDown= "Avenida indenpendencia";
        }

        [RelayCommand]
        async void OnItemSelected()
        {
            await Task.Run(() =>
            {
                //carrega algo
            });
        }
    }
}
