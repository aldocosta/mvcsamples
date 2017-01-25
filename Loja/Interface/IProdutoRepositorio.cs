using Loja.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Interface
{
    public interface IProdutoRepositorio
    {
        IQueryable<Produto> Produtos { get; }
        int Save(Produto produto);
        int Save();
        Produto Pesquisar(int id);
        void Editar(Produto produto);
        void Deletar(int id);
    }
}
