using Loja.Contexto;
using Loja.Entidade;
using Loja.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        EFDbContexto ctx = new EFDbContexto();
        public IQueryable<Entidade.Produto> Produtos
        {
            get { return ctx.Produtos; }
        }

        public int Save(Entidade.Produto produto)
        {
            ctx.Produtos.Add(produto);
            return ctx.SaveChanges();
        }

        public int Save()
        {
            return ctx.SaveChanges();
        }

        public Produto Pesquisar(int id)
        {
            return ctx.Produtos.Where(p => p.ProdutoId == id).FirstOrDefault();
        }


        public void Deletar(int id)
        {
            //var ret = ctx.Produtos.Where(p => p.ProdutoId == id).FirstOrDefault();
            var produto = new Produto()
            {
                ProdutoId = id
            };
            ctx.Produtos.Attach(produto);
            ctx.Produtos.Remove(produto);
            ctx.SaveChanges();
        }


        public void Editar(Produto produto)
        {
            var retorno = ctx.Produtos.Where(p => p.ProdutoId == produto.ProdutoId).FirstOrDefault();

            if (retorno != null)
            {
                retorno.Nome = produto.Nome;
                retorno.Preco = produto.Preco;
                retorno.Descricao = produto.Descricao;
                retorno.Categoria    = produto.Categoria;
            }

            ctx.SaveChanges();
        }
    }
}
