using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HW
{
    internal class Knight : Heros
    {
        public int NumberOfLegs { get; set; }
        public string Color { get; set; }
        public double Size { get; set; }
       

        public override string ToString()
        {
            return $"id number: {Id}";

        }
    }
}
