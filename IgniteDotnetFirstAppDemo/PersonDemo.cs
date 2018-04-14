using Apache.Ignite.Core;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache;
using System;

namespace IgniteDotnetFirstAppDemo
{
    class PersonDemo
    {
        static void Main(string[] args)
        {
            var cfg = new IgniteConfiguration
            {
                BinaryConfiguration = new BinaryConfiguration(typeof(Person))
            };
            IIgnite ignite = Ignition.Start(cfg);
            ICache<int, Person> cache = ignite.GetOrCreateCache<int, Person>("persons");

            cache[1] = new Person { Name = "HarshIT Lara", Age = 21 };

            foreach (ICacheEntry<int, Person> cacheEntry in cache)

                Console.WriteLine(cacheEntry);
                Console.ReadKey();
        }
    }
}
