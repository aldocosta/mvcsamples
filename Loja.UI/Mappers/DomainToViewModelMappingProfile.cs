using AutoMapper;
using Loja.Entidade;
using Loja.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.UI.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            CreateMap<Produto, ProdutoViewModel>();
            //CreateMap<Aluno, AlunoViewModel>();            
        }
    }
}
