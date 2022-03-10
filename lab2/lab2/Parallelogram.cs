using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Parallelogram : Figure
    {
        public double Storona { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return Storona * Height;
        }
    }
}
