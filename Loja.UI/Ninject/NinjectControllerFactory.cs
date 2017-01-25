using Loja.Interface;
using Loja.Repositorio;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Loja.UI.Ninject
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _kernel;

        public NinjectControllerFactory()
        {
            _kernel = new StandardKernel();
            AddBindings();
        }
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext,
            Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernel.Get(controllerType);            
        }

        private void AddBindings()
        {
            _kernel.Bind<IProdutoRepositorio>().To<ProdutoRepositorio>();
        }
    }
}