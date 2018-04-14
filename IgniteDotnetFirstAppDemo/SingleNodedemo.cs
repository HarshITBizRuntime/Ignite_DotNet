using Apache.Ignite.Core;
using Apache.Ignite.Core.Cache;
using System;
namespace IgniteDotnetFirstAppDemo
{
    class SingleNodedemo
    {
        static void Main(string[] args)
        {
            IIgnite ignite = Ignition.Start(); // this my Ignite Node
            ICache<int, string> cache = ignite.GetOrCreateCache<int, string>("single"); // Icatch is interface and There can be any number of caches per cluster.
            cache.Put(1, "Hello, World!");
            Console.WriteLine(cache.Get(1));
            Console.ReadKey();
        }
    }
}
