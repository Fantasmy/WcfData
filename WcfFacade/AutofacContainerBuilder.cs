using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfFacade
{
    public static class AutofacContainerBuilder
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            // registrar la interfaz del repository

            return builder.Build();
        }
    }
}