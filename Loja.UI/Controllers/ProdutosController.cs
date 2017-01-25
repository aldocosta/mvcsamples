using AutoMapper;
using Loja.Entidade;
using Loja.Interface;
using Loja.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Loja.UI.Controllers
{
    public class ProdutosController : Controller
    {
        private IProdutoRepositorio _repo;
        public ProdutosController(IProdutoRepositorio repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            var model = _repo.Produtos.ToList();
            var viewmodel = Mapper.Map<List<Produto>, List<ProdutoViewModel>>(model);

            return View(viewmodel);
        }

        public ActionResult CriarProduto()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CriarProduto(ProdutoViewModel pvm)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("CriarProduto");

            var model = Mapper.Map<ProdutoViewModel, Produto>(pvm);
            int ret = _repo.Save(model);

            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            var model = _repo.Pesquisar(id);
            var vm = Mapper.Map<Produto, ProdutoViewModel>(model);
            return View(vm);
        }

        [HttpPost]
        public ActionResult Editar(ProdutoViewModel pvm)
        {
            if (ModelState.IsValid)
            {
                var model = _repo.Pesquisar(pvm.ProdutoId);
                model.Categoria = pvm.Categoria;
                model.Descricao = pvm.Descricao;
                model.Nome = pvm.Nome;
                model.Preco = pvm.Preco;
                _repo.Save();
            }
            else
            {
                RedirectToAction("Editar");
            }

            return RedirectToAction("Index");
        }
        public ActionResult Deletar(int id)
        {
            var model = _repo.Pesquisar(id);
            var vm = Mapper.Map<Produto, ProdutoViewModel>(model);
            return View(vm);
        }

        public ActionResult DeletarRegistro(int id)
        {
            _repo.Deletar(id);
            
            return RedirectToAction("Index");
        }

    }
}
