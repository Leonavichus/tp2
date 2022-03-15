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
            return new Point((int)(Position.X), (int)(Position.Y));
        }

        public override void Draw(Graphics gr)
        {
            Pen brush = new Pen(Color);
            Point[] points = { new Point(230, 10), new Point(260, 10), new Point(290, 100), new Point(200, 100) };
            gr.DrawPolygon(brush, points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
