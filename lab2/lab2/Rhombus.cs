using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Rhombus : Figure
    {
        public double Diagonal { get; set; }
        public double Diagonal2 { get; set; }

        public override double GetArea()
        {
            return (Diagonal * Diagonal2) / 2;
        }
    }
}
