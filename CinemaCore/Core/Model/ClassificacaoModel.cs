using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CinemaCore.Core.Model
{
    public class ClassificacaoModel
    {
        public string CaracteristicaFilme { get; set; }
        public string PublicoAlvo { get; set; }
        public string Abreviacao { get; set; }
        public Color CorClassificacao { get; set; }
        private ClassificacaoModel(string publico, string abreviacao, string caracteristicas, Color corClassificacao)
        {
            PublicoAlvo = publico;
            CaracteristicaFilme = caracteristicas;
            Abreviacao = abreviacao;
        }

        public static ClassificacaoModel CrieClassificacaoLivre()
        {
            return new ClassificacaoModel("Livre","L",  "Não expõe crianças a conteúdo potencialmente prejudiciais", Color.Green);
        }

        public static ClassificacaoModel CrieClassificacaoPara10Anos()
        {
            return new ClassificacaoModel("Não recomendado para menores de 10 anos", "10+","Conteúdo violento ou linguagem inapropiada para crianças, ainda que em menor intensidade", Color.Blue);
        }

        public static ClassificacaoModel CrieClassificacaoPara12Anos()
        {
            return new ClassificacaoModel("Não recomendado para menores de 12 anos", "12+","As cenas podem conter agrssão física, consumo de drogas, e insinuação sexual", Color.Yellow);
        }

        public static ClassificacaoModel CrieClassificacaoPara14Anos()
        {
            return new ClassificacaoModel("Não recomendado para menores de 14 anos", "14+", "Conteúdos mais violentos e/ou de linguagem sexual mais acentuada", Color.Orange);
        }

        public static ClassificacaoModel CrieClassificacaoPara16Anos()
        {
            return new ClassificacaoModel("Não recomendado para menores de 16 anos", "16+", "Conteúdos mais violento ou com conteudo sexual mais intenso. com cenas de tortura, suicidio, estupro ou nudez total", Color.Red);
        }

        public static ClassificacaoModel CrieClassificacaoPara18Anos()
        {
            return new ClassificacaoModel("Não recomendado para menores de 18 anos", "18+", "Conteudos ciolentos e sexuais extremos, cenas de sexo, incesto ou atos repetidos de tortura, multilação ou abuso sexual", Color.Black);
        }
    }
}

