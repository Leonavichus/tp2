using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class RegularDecagon : Figure
    {
        public double Storona { get; set; }

        public override double GetArea()
        {
            return 5/2 * Math.Pow(Storona,2) * Math.Sqrt(5 + 2 * Math.Sqrt(5));
        }
    }
}
