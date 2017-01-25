using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Loja.Repositorio;
using System.Linq;
using Loja.Entidade;

namespace LojaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Produto p = new Produto();
            p.Categoria = "cat teste";
            p.Descricao = "desc teste";
            p.Nome = "teste";
            p.Preco = 22;
            p.ProdutoId = 20;

            ProdutoRepositorio pr = new ProdutoRepositorio();
            pr.Save(p);
        }
    }
}
