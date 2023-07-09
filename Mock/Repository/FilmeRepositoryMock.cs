using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using CinemaCore.Core.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock.Repository
{
    public class FilmeRepositoryMock : IFilmeRepository
    {
        private List<FilmeModel> _filmes = new List<FilmeModel>();
        public FilmeRepositoryMock()
        {
            _filmes.Add(new FilmeModel { Codigo = 1, 
                UrlImagem = "https://i0.wp.com/animagos.com.br/wp-content/uploads/2019/01/DVD-COG-v1.png?resize=759%2C1080", 
                AnoLancamento = 2022, 
                TipoFilme= "Aventuda",
                Classificacao = ClassificacaoModel.CrieClassificacaoPara12Anos(), 
                Duracao = new TimeSpan(1,20,25), 
                NomeFilme = "Animais Fantásticos: Os Segredos de Dumbledore", 
                Sinopse = "O professor Alvo Dumbledore (Jude Law) sabe que o poderoso mago das trevas Gellert Grindelwald (Mads Mikkelsen) está se movimentando para assumir o controle do mundo mágico. Incapaz de detê-lo sozinho, ele pede ao magizoologista Newt Scamander (Eddie Redmayne) para liderar uma intrépida equipe de bruxos, bruxas e um corajoso padeiro trouxa em uma missão perigosa, em que eles encontram velhos e novos animais fantásticos e entram em conflito com a crescente legião de seguidores de Grindelwald. Mas com tantas ameaças, quanto tempo poderá Dumbledore permanecer à margem do embate?" 
            });
            
            _filmes.Add(new FilmeModel { Codigo = 2, 
                UrlImagem = "https://cabanadoleitor.com.br/wp-content/uploads/2022/05/Tudo-em-Todo-o-Lugar-ao-Mesmo-Tempo-1280x1881.webp" ,
                AnoLancamento = 2022,
                TipoFilme = "Ficção",
                Classificacao = ClassificacaoModel.CrieClassificacaoPara14Anos(),
                Duracao = new TimeSpan(2,12,00),
                NomeFilme = "Tudo em Todo O Lugar ao Mesmo Tempo",
                Sinopse = "Evelyn Wang é uma sobrecarregada imigrante chinesa com uma lavanderia à beira do fracasso e um casamento com o marido covarde em ruínas, ela luta para lidar com tudo, incluindo um relacionamento ruim com seu pai crítico e sua filha (Stephanie Hsu). E, como se não bastasse enfrentar a crise pessoal, Evelyn precisa se preparar para uma reunião desagradável com uma burocrata impessoal: Deirdre, a auditora da Receita Federal. No entanto, à medida que a agente severa perde a paciência, uma inexplicável fenda no multiverso se abre, e se torna uma possibilidade para a exploração reveladora de realidades paralelas. Evelyn parte rumo a uma aventura onde, sozinha, precisará salvar o mundo e impedir que uma entidade maligna destrua as finas e incontáveis ​​camadas do mundo invisível. Explorando outros universos e outras vidas que poderia ter vivido, as coisas se complicam ainda mais, quando ela fica presa nessa infinidade de possibilidades sem conseguir retornar para casa."
            });

            _filmes.Add(new FilmeModel { Codigo = 3, 
                UrlImagem = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgWo55O_9TONhFgy8-npvXqlwr0DWBiD8rrwk9k-_sQujTC9obxblHfhY1BWbCajwF5r8&usqp=CAU",
                AnoLancamento = 2023,
                TipoFilme = "Crime, Ficção",
                Classificacao = ClassificacaoModel.CrieClassificacaoPara16Anos(),
                Duracao = new TimeSpan(1,50,00),
                NomeFilme = "John Wick 4: Baba Yaga",
                Sinopse = "John Wick enfrenta seus adversários mais letais até agora na próxima quarta parte da série. Com o preço de sua cabeça cada vez maior, Wick leva sua luta contra a Alta Mesa global enquanto procura os jogadores mais poderosos do submundo, de Nova York a Paris, Osaka e Berlim."

            });

            _filmes.Add(new FilmeModel { Codigo = 4, 
                UrlImagem = "https://cdnim.prd.cineticket.com.br/asset/movie/7841/dungeons-and-dragons-honra-entre-rebeldes-poster-tablet-4969c.jpg" ,
                AnoLancamento = 2023,
                TipoFilme = "Aventuda",
                Classificacao = ClassificacaoModel.CrieClassificacaoPara12Anos(),
                Duracao= new TimeSpan(1,12,00),
                NomeFilme = "Dungeons & Dragons: Honra Entre Rebeldes",
                Sinopse = "Um charmoso ladrão e um grupo de aventureiros mergulham em uma épica jornada para recuperar uma relíquia perdida – mas as coisas se tornam perigosamente obscuras quando eles cruzam caminho com as pessoas erradas. ‘Dungeons & Dragons: Honra Entre Rebeldes’ traz o rico mundo e o espírito vívido do lendário jogo de RPG para as telonas em uma aventura hilárias e recheada de ação."
            });
            
            _filmes.Add(new FilmeModel { Codigo = 5,
                UrlImagem = "https://a-static.mlcdn.com.br/800x560/poster-cartaz-o-hobbit-a-desolacao-de-smaug-c-pop-arte-poster/poparteskins2/15938538942/3379a0a59be06c210b747afa9f6b5512.jpeg",
                AnoLancamento = 2013,
                TipoFilme = "Aventuda",
                Classificacao = ClassificacaoModel.CrieClassificacaoPara12Anos(),
                Duracao = new TimeSpan (2,45,26),
                NomeFilme = "O Hobbit: A Desolação de Smaug",
                Sinopse = "Tendo sobrevivido ao início de sua jornada inesperada, o grupo continua em direção ao Leste, encontrando no caminho o metamorfo Beorn e aranhas gigantes da traiçoeira Floresta das Trevas. Depois de escapar do cativeiro dos perigosos Elfos da Floresta, os anões viajam para Esgaroth, a Cidade do Lago, e finalmente chegam à Montanha Solitária, onde devem enfrentar o maior perigo de todos – uma criatura mais aterrorizante que qualquer outra; uma que testará não apenas o nível de coragem dos aventureiros, mas também os limites de sua amizade e a sabedoria da própria jornada – o dragão Smaug."
            });
        }

        public async Task<FilmeModel> ObtenhaDetalhesFilme(int codigoFilme)
        {
            await Task.Delay(1000);
            return _filmes.First(x => x.Codigo == codigoFilme);
        }

    }
}
