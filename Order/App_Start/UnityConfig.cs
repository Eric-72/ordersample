using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using Unity.Mvc5;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Order.Service;
using Order.Data;
using Order.Models;
using Order.Controllers;
using System.Data.Entity;
using System.Web.Mvc;

namespace Order
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            container.RegisterType<IOrderService, OrderService>();
            container.RegisterType<IOrderDbContext, OrderDbContext>();

            container.RegisterType<DbContext, ApplicationDbContext>(new HierarchicalLifetimeManager());
            container.RegisterType<UserManager<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<AccountController>(new InjectionConstructor());
                       
            
            // Configures container for ASP.NET MVC
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));

            // Configures container for WebAPI
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}