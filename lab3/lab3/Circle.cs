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
            return new Point((int)(Position.X + Radius), (int)(Position.Y + Radius));
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(Color), Position.X, Position.Y, (int)(Radius + Radius), (int)(Radius + Radius));
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
