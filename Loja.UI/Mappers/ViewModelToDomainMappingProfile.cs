using AutoMapper;
using Loja.Entidade;
using Loja.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.UI.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            CreateMap<ProdutoViewModel, Produto>();
            //CreateMap<AlunoViewModel, Aluno>();               
        }
    }
}
