using ExternalLibrary;
using Microsoft.Practices.Unity;

namespace WebAPIpoc2.IoC
{
    public static class Container
    {
        private static UnityContainer _container;

        public static void InitializeIoC()
        {
            _container = new UnityContainer();

            //Normal lifetime
            _container.RegisterType<ILoggingComponent, LoggingComponent>();            
            //Singleton
            //_container.RegisterType<ILoggingComponent, LoggingComponent>(new ContainerControlledLifetimeManager());
        }

        public static UnityContainer GetContainer()
        {
            return _container;
        }
    }
}