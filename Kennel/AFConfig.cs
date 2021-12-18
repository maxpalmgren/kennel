using Autofac;
using Kennel.Classes;
using Kennel.Data;
using Kennel.ExtraService;
using Kennel.Interface;
using Kennel.Manager;
using Kennel.MOCKDATA;

namespace Kennel
{
    public static class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register Main Application
            builder.RegisterType<Application>().As<IApplication>();

            //MOckData
            builder.RegisterType<MockData>().As<IMockData>();

            //DatabaseList
            builder.RegisterType<DbLists>().As<IDbLists>().SingleInstance();

            // Register one by one
            builder.RegisterType<Customer>().As<IPerson>();
            builder.RegisterType<Dog>().As<IAnimal>();
            builder.RegisterType<MainMenu>().As<IMainMenu>();
            builder.RegisterType<CustomerManager>().As<ICustomerManager>();
            builder.RegisterType<AnimalManager>().As<IAnimalManager>();
            builder.RegisterType<KennelManager>().As<IKennelManager>();

            // Extra Services
            builder.RegisterType<ExtraHaircut>().As<IExtraHaircut>();
            builder.RegisterType<ExtraClawcut>().As<IExtraClawcut>();


            return builder.Build();
        }
    }
}