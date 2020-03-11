﻿using Name.Services;
using Autofac;

namespace Name
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            
            
            builder.RegisterType<Handler>().As<IHandler>();
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<ReadFromNameRepository>().As<IRead>();
            builder.RegisterType<Output>().As<IOutput>();
            builder.RegisterType<Name>().As<IName>();
            builder.RegisterType<NameParser>().As<INameParser>();
            builder.RegisterType<PersonDataContext>().As<IPersonDataContext>();
            builder.RegisterType<Sort>().As<ISort>();
            builder.RegisterType<WriteToNameRepository>().As<IWrite>();

            return builder.Build();
        }
    }
}