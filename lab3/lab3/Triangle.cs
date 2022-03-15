using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab3
{
    class Triangle : Figure
    {
        public double Osnov { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return (Osnov * Height) / 2;
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X), (int)(Position.Y - Height/2));
        }

        public override void Draw(Graphics gr)
        {
            Pen brush = new Pen(Color);
            Point[] points = { new Point(Position.X, Position.Y - (int)Height), new Point(Position.X + (int)Osnov / 2, Position.Y), new Point(Position.X - (int)Osnov / 2, Position.Y) };
            gr.DrawPolygon(brush, points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
