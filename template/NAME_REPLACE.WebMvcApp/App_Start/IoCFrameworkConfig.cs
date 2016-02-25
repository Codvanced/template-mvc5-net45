using IOC.FW.Abstraction.Container.Binding;
using IOC.FW.ContainerManager.DryIoc;
using NAME_REPLACE.Binding;
using System.Web.Http;
using DryIoc.Mvc;
using System.Web.Mvc;

namespace NAME_REPLACE.WebMvcApp
{
    public class IoCFrameworkConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var adapter = new DryIocAdapter();
            var binders = new IBinding[]{
                new BusinessBinder(),
                new DaoBinder(),
                new SharedBinder(),
                new IoCFrameworkBinder(),
            };

            foreach (var binder in binders)
                binder.SetBinding(adapter);

            var containerWithMvc = adapter._container.WithMvc();
            var ioc = new DryIocDependencyResolver(containerWithMvc);

            DependencyResolver.SetResolver(ioc);
        }
    }
}