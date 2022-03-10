using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Trapezoid : Figure
    {
        public double Osnov { get; set; }
        public double Osnov2 { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return (Osnov + Osnov2)/2 * Height;
        }
    }
}
