using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Circle : Figure
    {
        public float pi = 3.14f;

        public double Radius { get; set; }

        public override double GetArea()
        {
            return pi * Math.Pow(Radius,2);
        }
    }
}
