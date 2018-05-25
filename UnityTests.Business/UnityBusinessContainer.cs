using Unity.Extension;
using UnityTests.Common;
using UnityTests.Data;

namespace UnityTests.Business
{
    public class UnityBusinessContainer : UnityContainerExtension
    {
        protected override void Initialize()
        {
            DependencyInjector.AddExtension<UnityDataContainer>();

            DependencyInjector.Register<IBusiness, BusinessClass>(LifetimeEnum.Transcient);
        }
    }
}
