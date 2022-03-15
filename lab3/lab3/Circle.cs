using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab3
{
    class Circle : Figure
    {
        public float pi = 3.14f;

        public double Radius { get; set; }

        public override double GetArea()
        {
            return pi * Math.Pow(Radius, 2);
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Radius / 2), (int)(Position.Y + Radius / 2));
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(Color), Position.X, Position.Y, (int)Radius, (int)Radius);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
