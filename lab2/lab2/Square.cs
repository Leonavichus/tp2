using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Square : Figure
    {
        public double Storona { get; set; }

        public override double GetArea()
        {
            return Math.Pow(Storona, 2);
        }
    }
}
