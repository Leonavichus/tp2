using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Triangle : Figure
    {
        public double Osnov { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return (Osnov * Height)/2;
        }
    }
}
