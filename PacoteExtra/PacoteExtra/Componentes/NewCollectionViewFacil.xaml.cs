using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class NewCollectionViewFacil : CollectionView
    {
        public static string TemplateBuscaShopping = "TemplateBuscaShopping";
        public static string TemplateRecursosFilme = "TemplateRecursosFilme";
        public static string TemplateListaImagem = "TemplateListaImagem";
        public static string TemplateVazia = "TemplateVazia";
        public static string TemplateVisualizacaoDia = "TemplateVisualizacaoDia";
        public static string ProgramacaoFilmeTemplate = "ProgramacaoFilmeTemplate";

        public static readonly BindableProperty TemplateProperty = BindableProperty.Create(nameof(Template), typeof(string), typeof(NewCollectionViewFacil), null);
        public static readonly BindableProperty ReaderTemplateCollectionViewProperty = BindableProperty.Create(nameof(AgrupamentoHeader), typeof(string), typeof(NewCollectionViewFacil), null);
        public static readonly BindableProperty ItensOrigemProperty = BindableProperty.Create(nameof(ItensOrigem), typeof(List<CollectionViewModel>), typeof(NewCollectionViewFacil), null);
        public static readonly BindableProperty AoPressionarProperty = BindableProperty.Create(nameof(AoPressionar), typeof(ICommand), typeof(NewCollectionViewFacil), null);
        public static readonly BindableProperty OrientacaoListaProperty = BindableProperty.Create(nameof(OrientacaoTemplate), typeof(ItemsLayoutOrientation), typeof(NewCollectionViewFacil), null);
        public static readonly BindableProperty SpanCollectionProperty = BindableProperty.Create(nameof(SpanCollection), typeof(int), typeof(NewCollectionViewFacil), null);
        public static readonly BindableProperty NomeProperty = BindableProperty.Create(nameof(Nome), typeof(string), typeof(NewCollectionViewFacil), null);


        public NewCollectionViewFacil()
        {
            InitializeComponent();
            SpanCollection = 1;
        }

        public List<CollectionViewModel> ItensOrigem
        {
            get { return (List<CollectionViewModel>)GetValue(ItensOrigemProperty); }
            set { SetValue(ItensOrigemProperty, value); }
        }
        public string Template
        {
            get { return (string)GetValue(TemplateProperty); }
            set { SetValue(TemplateProperty, value); }
        }
        public string Nome
        {
            get { return (string)GetValue(NomeProperty); }
            set { SetValue(NomeProperty, value); }
        }
        public int SpanCollection
        {
            get { return (int)GetValue(SpanCollectionProperty); }
            set { SetValue(SpanCollectionProperty, value); }
        }
        public string AgrupamentoHeader
        {
            get { return (string)GetValue(ReaderTemplateCollectionViewProperty); }
            set { SetValue(ReaderTemplateCollectionViewProperty, value); }
        }
        public ICommand AoPressionar
        {
            get { return (ICommand)GetValue(AoPressionarProperty); }
            set { SetValue(AoPressionarProperty, value);}
        }
       

        public ItemsLayoutOrientation _orientacaoTemplate;
        public ItemsLayoutOrientation OrientacaoTemplate
        {
            get { return (ItemsLayoutOrientation)GetValue(OrientacaoListaProperty); }
            set { SetValue(OrientacaoListaProperty, value); }
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == nameof(OrientacaoTemplate) || propertyName == nameof(SpanCollection))
            {
                ItemsLayout = new GridItemsLayout(SpanCollection, OrientacaoTemplate);
            }
            if (propertyName == nameof(Nome))
            {
                //if(Nome == "Picture")
                //{
                //    ItensOrigem = new List<string>() { "18", "3D" };
                //}
            }
            if (propertyName == nameof(Template))
            {

            }
            if (propertyName == nameof(ItensOrigem))
            {
                CarregueItemSource();
            }
        }
        public DataTemplate ResolvaTemplate(string nomeTemplate)
        {
            if (this.Resources.TryGetValue(nomeTemplate, out var template))
            {
                return (DataTemplate)template;
            }
            return null;
        }
        private void CarregueItemSource()
        {
            if (ItensOrigem?.Any() ?? false)
            {
                if (!string.IsNullOrWhiteSpace(AgrupamentoHeader))
                {
                    CarregueAgrupamento();
                }
                else
                {
                    CarregueLista();
                }
            }
            else
            {
                //CarregueTemplateVazio();
            }
        }

        private void CarregueLista()
        {
            ItemTemplate = ResolvaTemplate(Template);
            ItemsSource = ItensOrigem;
        }

        private void CarregueAgrupamento()
        {

        }
        private void ItemDeLIstatapped(object sender, EventArgs e)
        {
            var item = ((TappedEventArgs)e).Parameter;
            if (Template == TemplateBuscaShopping)
            {
                MarqueSelecaoDeElemento(item);
            }
            if (AoPressionar?.CanExecute(item) ?? false)
            {
                AoPressionar.Execute(item);
            }
        }
        private void MarqueSelecaoDeElemento(object item)
        {
            var novaListaDeElementos = new List<CollectionViewModel>();
            var listaItemSource = (List<CollectionViewModel>)ItensOrigem;

            if (listaItemSource == null || !listaItemSource.Any())
            {
                return;
            }

            foreach (var i in listaItemSource)
            {
                var elemento = (CollectionViewModel)i;
                elemento.PropriedadeBoleana = elemento.Equals((CollectionViewModel)item);
                novaListaDeElementos.Add(elemento);
            }

            ItemsSource = novaListaDeElementos;
        }
    }

    public partial class CollectionViewModel : ObservableObject
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Descricao1 { get; set; }
        public string Descricao2 { get; set; }
        public string Descricao3 { get; set; }
        public string Descricao4 { get; set; }
        public bool PropriedadeBoleana { get; set; }

        [ObservableProperty]
        public List<CollectionViewModel> propriedadeEmlista;
        public Command PropriedadeEmListaToque { get; set; }
        [RelayCommand]
        public void PropriedadeEmListaAoPressionar(object objeto)
        {
            if (PropriedadeEmListaToque?.CanExecute(objeto) ?? false)
            {
                PropriedadeEmListaToque.Execute(objeto);
            }
        }

        [ObservableProperty]
        public List<CollectionViewModel> propriedadeEmlista2;
        public Command PropriedadeEmListaToque2 { get; set; }
        [RelayCommand]
        public void PropriedadeEmLista2AoPressionar(object objeto)
        {
            if (PropriedadeEmListaToque?.CanExecute(objeto) ?? false)
            {
                PropriedadeEmListaToque.Execute(objeto);
            }
        }

       
        [ObservableProperty]
        string corElemento;
    }
}