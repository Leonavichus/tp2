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
            return new Point((int)(Position.X), (int)(Position.Y - Height / 2));
        }

        public override void Draw(Graphics gr)
        {
            Pen brush = new Pen(Color);
            Point[] points = { new Point(Position.X - (int)Storona / 2, Position.Y), new Point(Position.X - (int)Storona / 4, Position.Y - (int)Height), 
                new Point(Position.X + (int)Storona / 2 + (int)Storona / 4, Position.Y - (int)Height), new Point(Position.X + (int)Storona / 2, Position.Y) };
            gr.DrawPolygon(brush, points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
