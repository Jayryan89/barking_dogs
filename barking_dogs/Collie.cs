using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barking_dogs
{
    class Collie : IBark
    {
        public string Name { get; set; } = "Apollo";
        public string Color { get; set; } = "Black";
        public string Barksound { get; set; } = "Woof";

        public string Bark()
        {
            return Barksound;
        }
    }
}
