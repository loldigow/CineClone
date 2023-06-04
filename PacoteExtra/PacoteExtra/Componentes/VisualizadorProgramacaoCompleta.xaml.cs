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
    [ObservableObject]
    public partial class InicioViewModel
    {
        [ObservableProperty]
        public List<CollectionViewModel> favoritosList;

        [ObservableProperty]
        public List<CollectionViewModel> filmeList;

        public InicioViewModel()
        {
            CarregueFilmes();
        }

        private void CarregueFilmes()
        {
            var listaFilmes = new List<FilmeModel>();
            listaFilmes.Add(new FilmeModel { Id = 1, Imagem = "https://i0.wp.com/animagos.com.br/wp-content/uploads/2019/01/DVD-COG-v1.png?resize=759%2C1080" });
            listaFilmes.Add(new FilmeModel { Id = 2, Imagem = "https://cabanadoleitor.com.br/wp-content/uploads/2022/05/Tudo-em-Todo-o-Lugar-ao-Mesmo-Tempo-1280x1881.webp" });
            listaFilmes.Add(new FilmeModel { Id = 3, Imagem = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgWo55O_9TONhFgy8-npvXqlwr0DWBiD8rrwk9k-_sQujTC9obxblHfhY1BWbCajwF5r8&usqp=CAU" });
            listaFilmes.Add(new FilmeModel { Id = 4, Imagem = "https://cdnim.prd.cineticket.com.br/asset/movie/7841/dungeons-and-dragons-honra-entre-rebeldes-poster-tablet-4969c.jpg" });
            listaFilmes.Add(new FilmeModel { Id = 5, Imagem = "https://a-static.mlcdn.com.br/800x560/poster-cartaz-o-hobbit-a-desolacao-de-smaug-c-pop-arte-poster/poparteskins2/15938538942/3379a0a59be06c210b747afa9f6b5512.jpeg" });
            var listaDeFavoritos = new List<FilmeModel>();
            listaDeFavoritos.Add(listaFilmes.First());
            FilmeList = listaFilmes.Select(x => new CollectionViewModel() { Id = x.Id, Descricao = x.Imagem }).ToList();
            var favorito = listaFilmes.First();
            FavoritosList = new List<CollectionViewModel>() { new CollectionViewModel{
                Id = favorito.Id,
                Descricao = favorito.Imagem
            } };

        }

        [RelayCommand]
        public void ProgramacaoCompletaClick()
        {

        }

        [RelayCommand]
        public async void PesquisaShopping()
        {
            await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new BuscaShoppingPage()));
        }

        [RelayCommand]
        public void CuponsClick()
        {

        }

        [RelayCommand]
        public void FilmeClik(object filmeSelecionado)
        {

        }
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
