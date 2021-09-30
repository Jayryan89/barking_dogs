using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barking_dogs
{
    interface IBark
    {
        string Name { get; set; }
        string Color { get; set; }
        string Barksound { get; set; }

        string Bark();
    }
}
