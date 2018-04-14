using System;
using Apache.Ignite.Core;

namespace IgniteDotnetFirstAppDemo
{
    class First
    {
        static void Main(string[] args)
        {
            Ignition.Start();
            Console.WriteLine("its working "); 
            Console.ReadKey(); 

        }
    }
}
