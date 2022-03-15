using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab3
{
    class Trapezoid : Figure
    {
        public double Osnov { get; set; }
        public double Osnov2 { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return (Osnov + Osnov2) / 2 * Height;
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X), (int)(Position.Y - Height / 2));
        }

        public override void Draw(Graphics gr)
        {
            Pen brush = new Pen(Color);
            Point[] points = { new Point(Position.X - (int)Osnov / 2, Position.Y), new Point(Position.X - (int)Osnov2 / 2, Position.Y - (int)Height), 
                new Point(Position.X + (int)Osnov2 / 2, Position.Y-(int)Height), new Point(Position.X + (int)Osnov / 2, Position.Y) };
            gr.DrawPolygon(brush, points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
