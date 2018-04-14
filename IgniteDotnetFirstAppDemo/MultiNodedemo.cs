using Apache.Ignite.Core;
using Apache.Ignite.Core.Cache;
using System;

namespace IgniteDotnetFirstAppDemo
{
    class MultiNodedemo
    {
        static void Main(string[] args)
        {
            IIgnite ignite = Ignition.Start();
            ICache<int, string> cache = ignite.GetOrCreateCache<int, string>("MultiCatch");

            cache.Put(1, "Hello, World!");

            if (cache.PutIfAbsent(1, "HelldWorld Absent"))

                Console.WriteLine("Added a value to the cache!");
            else
                Console.WriteLine(cache.Get(1));
            Console.ReadKey();
        }
    }
}
