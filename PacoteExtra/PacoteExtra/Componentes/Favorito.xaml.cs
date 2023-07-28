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
    public partial class Favorito : ContentView
    {
        private readonly string Check = "check.png";
        private readonly string Uncheck = "uncheck.png";


        public static BindableProperty TamanhoProperty = BindableProperty.Create(nameof(Tamanho), typeof(double), typeof(Favorito), null);
        public static BindableProperty LarguraProperty = BindableProperty.Create(nameof(Largura), typeof(double), typeof(Favorito), null);
        public static BindableProperty EhFavoritoProperty = BindableProperty.Create(nameof(EhFavorito), typeof(bool), typeof(Favorito), null);
        public static BindableProperty AoSelecionarFavoritoProperty = BindableProperty.Create(nameof(AoSelecionarFavorito), typeof(ICommand), typeof(Favorito), null);

        public ICommand AoSelecionarFavorito
        {
            get { return (ICommand)GetValue(AoSelecionarFavoritoProperty); }
            set { SetValue(AoSelecionarFavoritoProperty, value); }
        }
        public bool EhFavorito
        {
            get { return (bool)GetValue(EhFavoritoProperty); }
            set { SetValue(EhFavoritoProperty, value); }
        }

        public double Tamanho
        {
            get { return (double)GetValue(TamanhoProperty); }
            set { SetValue(TamanhoProperty, value); }
        }
        public double Largura
        {
            get { return (double)GetValue(LarguraProperty); }
            set { SetValue(LarguraProperty, value); }
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (nameof(Tamanho).Equals(propertyName))
            {
                FavoritoCheck.HeightRequest = Tamanho;
            }
            if (nameof(Largura).Equals(propertyName))
            {
                FavoritoCheck.WidthRequest = Largura;
            }
            if (nameof(EhFavorito).Equals(propertyName))
            {
                FavoritoCheck.Source = EhFavorito ? Check : Uncheck;
            }

        }

        public Favorito()
        {
            InitializeComponent();
            FavoritoCheck.Source = Uncheck;
            Tamanho = 50;
            Largura = 50;
            EhFavorito = false;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var boleano = !EhFavorito;
            FavoritoCheck.Source = boleano ? Check : Uncheck;
            EhFavorito = boleano;
            if(AoSelecionarFavorito?.CanExecute(null) ?? false) {
                AoSelecionarFavorito.Execute(null);
            }
            
        }
    }
}