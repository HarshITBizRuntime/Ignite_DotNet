using Apache.Ignite.Core;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgniteDotnetFirstAppDemo
{
    class PersonDemoBinarySerlization
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

            var binCache = cache.WithKeepBinary<int, IBinaryObject>();

            IBinaryObject binPerson = binCache[1];
            Console.WriteLine(binPerson.GetField<string>("Name"));
            Console.ReadKey();
        }
    }
}
