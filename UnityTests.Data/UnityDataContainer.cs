using Unity.Extension;
using UnityTests.Common;

namespace UnityTests.Data
{
    public class UnityDataContainer : UnityContainerExtension
    {
        protected override void Initialize()
        {
            DependencyInjector.Register<IData, DataClass>(LifetimeEnum.Transcient);
        }
    }
}
