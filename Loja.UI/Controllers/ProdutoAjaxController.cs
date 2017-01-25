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
    public class ProdutoAjaxController : Controller
    {
        private IProdutoRepositorio _repo;
        public ProdutoAjaxController(IProdutoRepositorio repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult RetornarProdutos()
        {
            var ret = _repo.Produtos.ToList();
            return Json(ret, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AtualizarProduto(ProdutoViewModel pv)
        {
            var retorno = Mapper.Map<ProdutoViewModel, Produto>(pv);
            _repo.Editar(retorno);

            return Json("Registro atualizado com sucesso", JsonRequestBehavior.AllowGet);
        }

    }
}
