using AutoMapper;
using CinemaCore.Core.Model;
using PacoteExtra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PacoteExtra.MeuMapper
{
    public static class Mapper
    { 
        public static IMapper Mapeamento { get; set; }

        public static void CrieMapeamento()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<FilmeViewModel, FilmeModel>();
                cfg.CreateMap<FilmeModel, FilmeViewModel>();
            });
            Mapeamento = configuration.CreateMapper();
        }
    }
}
