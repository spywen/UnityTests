using System;
using UnityTests.Common;

namespace UnityTests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UnityContainerBootstrapper.Init();
            Initiator initiator = DependencyInjector.Retrieve<Initiator>();

            string data = initiator.FetchData();
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
