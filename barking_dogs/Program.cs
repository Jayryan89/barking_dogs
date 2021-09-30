using System;
using System.Collections.Generic;

namespace barking_dogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new List<IBark>()
            {
                new Collie(),
                new Boxer(),
                new Chihuahua()

            };
            foreach (var dog in dogs)
            {
                Console.WriteLine($"The dog {dog.Name} barks {dog.Bark()}");
            }
        }
    }
}
