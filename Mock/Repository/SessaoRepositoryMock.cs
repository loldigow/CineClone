using CinemaCore.Core.Interface;
using CinemaCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock.Repository
{
    public class SessaoRepositoryMock : ISessaoRepository
    {
        List<SessaoModel> _sessaoModels;
        public SessaoRepositoryMock()
        {
            _sessaoModels = new List<SessaoModel>() {
                new SessaoModel() { Codigo = 1, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,15, 16,00,00), CodigoFilial = 1, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 2, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,15, 18,00,00), CodigoFilial = 1, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 3, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,15, 20,00,00), CodigoFilial = 1, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 4, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,15, 16,00,00), CodigoFilial = 2, CodigoFilme = 4 },
                new SessaoModel() { Codigo = 5, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,15, 18,00,00), CodigoFilial = 2, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 6, DescricaoSessao = "Sala C+3D", DataSessao = new DateTime(2023,07,15, 22,00,00), CodigoFilial = 1, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 7, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,15, 16,00,00), CodigoFilial = 3, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 8, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,15, 18,00,00), CodigoFilial = 3, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 9, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,15, 16,00,00), CodigoFilial = 4, CodigoFilme = 4 },
                new SessaoModel() { Codigo = 0, DescricaoSessao = "Sala G", DataSessao = new DateTime(2023,07,15, 22,00,00), CodigoFilial = 4, CodigoFilme = 5 },

                new SessaoModel() { Codigo = 10, DescricaoSessao = "Sala G", DataSessao = new DateTime(2023,07,15, 22,00,00), CodigoFilial = 4, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 11, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,15, 16,00,00), CodigoFilial = 1, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 12, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,15, 18,00,00), CodigoFilial = 1, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 13, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,15, 20,00,00), CodigoFilial = 1, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 14, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,15, 16,00,00), CodigoFilial = 2, CodigoFilme = 4 },
                new SessaoModel() { Codigo = 15, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,15, 18,00,00), CodigoFilial = 2, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 16, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,15, 20,00,00), CodigoFilial = 2, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 17, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,15, 16,00,00), CodigoFilial = 3, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 18, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,15, 18,00,00), CodigoFilial = 3, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 19, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,15, 16,00,00), CodigoFilial = 4, CodigoFilme = 4 },

                new SessaoModel() { Codigo = 20, DescricaoSessao = "Sala G", DataSessao = new DateTime(2023,07,16, 22,00,00), CodigoFilial = 4, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 21, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,16, 16,00,00), CodigoFilial = 1, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 22, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,16, 18,00,00), CodigoFilial = 1, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 23, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,16, 20,00,00), CodigoFilial = 1, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 24, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,16, 16,00,00), CodigoFilial = 2, CodigoFilme = 4 },
                new SessaoModel() { Codigo = 25, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,16, 18,00,00), CodigoFilial = 2, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 26, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,16, 20,00,00), CodigoFilial = 2, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 27, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,16, 16,00,00), CodigoFilial = 3, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 28, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,16, 18,00,00), CodigoFilial = 3, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 29, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,16, 16,00,00), CodigoFilial = 4, CodigoFilme = 4 },

                new SessaoModel() { Codigo = 30, DescricaoSessao = "Sala G", DataSessao = new DateTime(2023,07,16, 22,00,00), CodigoFilial = 4, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 31, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,16, 16,00,00), CodigoFilial = 1, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 32, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,16, 18,00,00), CodigoFilial = 1, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 33, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,16, 20,00,00), CodigoFilial = 1, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 34, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,16, 16,00,00), CodigoFilial = 2, CodigoFilme = 4 },
                new SessaoModel() { Codigo = 35, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,16, 18,00,00), CodigoFilial = 2, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 36, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,16, 20,00,00), CodigoFilial = 2, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 37, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,16, 16,00,00), CodigoFilial = 3, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 38, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,16, 18,00,00), CodigoFilial = 3, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 39, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,16, 16,00,00), CodigoFilial = 4, CodigoFilme = 4 },

                new SessaoModel() { Codigo = 40, DescricaoSessao = "Sala G", DataSessao = new DateTime(2023,07,20, 22,00,00), CodigoFilial = 4, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 41, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,20, 16,00,00), CodigoFilial = 1, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 42, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,20, 18,00,00), CodigoFilial = 1, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 43, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,20, 20,00,00), CodigoFilial = 1, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 44, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,20, 16,00,00), CodigoFilial = 2, CodigoFilme = 4 },
                new SessaoModel() { Codigo = 45, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,20, 18,00,00), CodigoFilial = 2, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 46, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,20, 20,00,00), CodigoFilial = 2, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 47, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,20, 16,00,00), CodigoFilial = 3, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 48, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,20, 18,00,00), CodigoFilial = 3, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 49, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,20, 16,00,00), CodigoFilial = 4, CodigoFilme = 4 },

                new SessaoModel() { Codigo = 50, DescricaoSessao = "Sala G", DataSessao = new DateTime(2023,07,22, 22,00,00), CodigoFilial = 4, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 51, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,22, 16,00,00), CodigoFilial = 1, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 52, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,22, 18,00,00), CodigoFilial = 1, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 53, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,22, 20,00,00), CodigoFilial = 1, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 54, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,22, 16,00,00), CodigoFilial = 2, CodigoFilme = 4 },
                new SessaoModel() { Codigo = 55, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,22, 18,00,00), CodigoFilial = 2, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 56, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,22, 20,00,00), CodigoFilial = 2, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 57, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,22, 16,00,00), CodigoFilial = 3, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 58, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,22, 18,00,00), CodigoFilial = 3, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 59, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,22, 16,00,00), CodigoFilial = 4, CodigoFilme = 4 },

                new SessaoModel() { Codigo = 60, DescricaoSessao = "Sala G", DataSessao = new DateTime(2023,07,23, 22,00,00), CodigoFilial = 4, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 61, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,23, 16,00,00), CodigoFilial = 1, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 62, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,23, 18,00,00), CodigoFilial = 1, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 63, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,23, 20,00,00), CodigoFilial = 1, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 64, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,23, 16,00,00), CodigoFilial = 2, CodigoFilme = 4 },
                new SessaoModel() { Codigo = 65, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,23, 18,00,00), CodigoFilial = 2, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 66, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,23, 20,00,00), CodigoFilial = 2, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 67, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,23, 16,00,00), CodigoFilial = 3, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 68, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,23, 18,00,00), CodigoFilial = 3, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 69, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,23, 16,00,00), CodigoFilial = 4, CodigoFilme = 4 },

                new SessaoModel() { Codigo = 70, DescricaoSessao = "Sala G", DataSessao = new DateTime(2023,07,24, 22,00,00), CodigoFilial = 4, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 71, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,24, 16,00,00), CodigoFilial = 1, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 72, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,24, 18,00,00), CodigoFilial = 1, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 73, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,24, 20,00,00), CodigoFilial = 1, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 74, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,24, 16,00,00), CodigoFilial = 2, CodigoFilme = 4 },
                new SessaoModel() { Codigo = 75, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,24, 18,00,00), CodigoFilial = 2, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 76, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,24, 20,00,00), CodigoFilial = 2, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 77, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,24, 16,00,00), CodigoFilial = 3, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 78, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,24, 18,00,00), CodigoFilial = 3, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 79, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,24, 16,00,00), CodigoFilial = 4, CodigoFilme = 4 },

                new SessaoModel() { Codigo = 80, DescricaoSessao = "Sala G", DataSessao = new DateTime(2023,07,25, 22,00,00), CodigoFilial = 4, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 81, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,25, 16,00,00), CodigoFilial = 1, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 82, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,25, 18,00,00), CodigoFilial = 1, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 83, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,25, 20,00,00), CodigoFilial = 1, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 84, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,25, 16,00,00), CodigoFilial = 2, CodigoFilme = 4 },
                new SessaoModel() { Codigo = 85, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,25, 18,00,00), CodigoFilial = 2, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 86, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,25, 20,00,00), CodigoFilial = 2, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 87, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,25, 16,00,00), CodigoFilial = 3, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 88, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,25, 18,00,00), CodigoFilial = 3, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 89, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,25, 16,00,00), CodigoFilial = 4, CodigoFilme = 4 },

                new SessaoModel() { Codigo = 90, DescricaoSessao = "Sala G", DataSessao = new DateTime(2023,07,26, 22,00,00), CodigoFilial = 4, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 91, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,26, 16,00,00), CodigoFilial = 1, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 92, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,26, 18,00,00), CodigoFilial = 1, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 93, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,26, 20,00,00), CodigoFilial = 1, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 94, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,26, 16,00,00), CodigoFilial = 2, CodigoFilme = 4 },
                new SessaoModel() { Codigo = 95, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,26, 18,00,00), CodigoFilial = 2, CodigoFilme = 5 },
                new SessaoModel() { Codigo = 96, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,26, 20,00,00), CodigoFilial = 2, CodigoFilme = 1 },
                new SessaoModel() { Codigo = 97, DescricaoSessao = "Sala A", DataSessao = new DateTime(2023,07,26, 16,00,00), CodigoFilial = 3, CodigoFilme = 2 },
                new SessaoModel() { Codigo = 98, DescricaoSessao = "Sala B", DataSessao = new DateTime(2023,07,26, 18,00,00), CodigoFilial = 3, CodigoFilme = 3 },
                new SessaoModel() { Codigo = 99, DescricaoSessao = "Sala C", DataSessao = new DateTime(2023,07,26, 16,00,00), CodigoFilial = 4, CodigoFilme = 4 },

                new SessaoModel() { Codigo = 100, DescricaoSessao = "Sala G", DataSessao = new DateTime(2023,07,27, 22,00,00), CodigoFilial = 4, CodigoFilme = 5 }};
        }
        public async Task<List<SessaoModel>> ObtenhaSessoes(int codigoFilme, int codigofilial, DateTime dataInicioBusca, DateTime dataFimBusca)
        {
            await Task.Delay(1000);
            return _sessaoModels.Where(x => x.CodigoFilial == codigofilial
            && x.CodigoFilme == codigoFilme
            && dataInicioBusca <= x.DataSessao
            && x.DataSessao <= dataFimBusca).ToList();
        }
    }
}
