using Calculator.Core.Calculators;
using Calculator.Core.Helpers;
using Unity;
using Unity.Lifetime;

namespace Calculator.App_Start
{
    public static class Unity_Config
    {
        public static IUnityContainer RegisterInstances(this IUnityContainer container)
        {
            container.RegisterType<ICalculator, ExpressionCalculator>();
            return container;
        }

        public static IUnityContainer RegisterSingletons(this IUnityContainer container)
        {
            container.RegisterType<IContainerHelper,ContainerHelper>(new ContainerControlledLifetimeManager());
            return container;
        }
    }
}
