using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab3
{
    class Parallelogram : Figure
    {
        public double Storona { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return Storona * Height;
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X), (int)(Position.Y));
        }

        public override void Draw(Graphics gr)
        {
            Pen brush = new Pen(Color);
            Point[] points = { new Point(430, 50), new Point(490, 50), new Point(460, 80), new Point(400, 80) };
            gr.DrawPolygon(brush, points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
