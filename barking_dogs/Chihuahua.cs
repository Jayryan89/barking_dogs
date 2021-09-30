using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barking_dogs
{
    class Chihuahua : IBark
    {
        public string Name { get; set; } = "Mya";
        public string Color { get; set; } = "blue";
        public string Barksound { get; set; } = "Squeek!";

        public string Bark()
        {
            return Barksound;
        }
    }
}
