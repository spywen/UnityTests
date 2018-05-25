using Unity;
using Unity.Extension;
using Unity.Lifetime;

namespace UnityTests.Common
{
    public class DependencyInjector
    {
        private static readonly UnityContainer UnityContainer = new UnityContainer();

        public static void Register<I, T>(LifetimeEnum lifetimeEnum) where T : I
        {
            switch (lifetimeEnum)
            {
                case LifetimeEnum.Transcient:
                    UnityContainer.RegisterType<I, T>(new TransientLifetimeManager());
                    break;
                case LifetimeEnum.Singleton:
                    UnityContainer.RegisterType<I, T>(new ContainerControlledLifetimeManager());
                    break;
                case LifetimeEnum.Hierarchical:
                    UnityContainer.RegisterType<I, T>(new HierarchicalLifetimeManager());
                    break;
                case LifetimeEnum.PerResolve:
                    UnityContainer.RegisterType<I, T>(new PerResolveLifetimeManager());
                    break;
                case LifetimeEnum.PerThread:
                    UnityContainer.RegisterType<I, T>(new PerThreadLifetimeManager());
                    break;
                case LifetimeEnum.External:
                    UnityContainer.RegisterType<I, T>(new ExternallyControlledLifetimeManager());
                    break;
                default:
                    UnityContainer.RegisterType<I, T>(new ContainerControlledTransientManager());
                    break;
            }

        }

        public static T Retrieve<T>()
        {
            return UnityContainer.Resolve<T>();
        }

        public static void AddExtension<T>() where T : UnityContainerExtension
        {
            UnityContainer.AddNewExtension<T>();
        }
    }
}
