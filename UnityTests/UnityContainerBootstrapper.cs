using UnityTests.Business;
using UnityTests.Common;

namespace UnityTests
{
    public static class UnityContainerBootstrapper
    {
        public static void Init()
        {
            DependencyInjector.AddExtension<UnityBusinessContainer>();
        }
    }
}
