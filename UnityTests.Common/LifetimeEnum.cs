namespace UnityTests.Common
{
    public enum LifetimeEnum
    {
        /// <summary>
        /// TransientLifetimeManager
        /// Creates a new object of requested type every time you call Resolve or ResolveAll method.
        /// </summary>
        Transcient = 0,
        /// <summary>
        /// ContainerControlledLifetimeManager
        /// Creates a singleton object first time you call Resolve or ResolveAll method and then returns the same object on subsequent Resolve or ResolveAll call.
        /// </summary>
        Singleton = 1,
        /// <summary>
        /// HierarchicalLifetimeManager
        /// Same as ContainerControlledLifetimeManager, the only difference is that child container can create its own singleton object. Parent and child container do not share singleton object.
        /// </summary>
        Hierarchical = 2,
        /// <summary>
        /// PerResolveLifetimeManager
        /// Similar to TransientLifetimeManager but it reuses the same object of registered type in the recursive object graph.
        /// </summary>
        PerResolve = 3,
        /// <summary>
        /// PerThreadLifetimeManager
        /// Creates singleton object per thread basis. It returns different objects from the container on different threads.
        /// </summary>
        PerThread = 4,
        /// <summary>
        /// ExternallyControlledLifetimeManager It maintains only weak reference of objects it creates when you call Resolve or ResolveAll method. It does not maintain the lifetime of strong objects it creates and allow you or garbage collector to control the lifetime. It enables you to create your own custom lifetime manager
        /// </summary>
        External = 5
    }
}
