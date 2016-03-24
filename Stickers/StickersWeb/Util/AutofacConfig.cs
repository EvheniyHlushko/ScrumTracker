using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using BusinessLayer;
using Contracts.IManager;

namespace StickersWeb.Util
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

           
            builder.RegisterType<ManagerDepartament>().As<IManagerDepartament>().InstancePerLifetimeScope();
            builder.RegisterType<ManagerTeam>().As<IManagerTeam>().InstancePerLifetimeScope();
            builder.RegisterType<ManagerUserTeamPos>().As<IManagerUserTeamPos>().InstancePerLifetimeScope();
            builder.RegisterType<ManagerUser>().As<IManagerUser>().InstancePerLifetimeScope();
            builder.RegisterType<ManagerProject>().As<IManagerProject>().InstancePerLifetimeScope();


            var container = builder.Build();

          DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}