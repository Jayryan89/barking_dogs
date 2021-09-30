using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barking_dogs
{
    class Boxer : IBark
    {
        public string Name { get; set; } = "Max";
        public string Color { get; set; } = "white";
        public string Barksound { get; set; } = "Ruff";

        public string Bark()
        {
            return Barksound;
        }
    }
}
