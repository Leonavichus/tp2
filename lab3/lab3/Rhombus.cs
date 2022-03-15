using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab3
{
    class Rhombus : Figure
    {
        public double Diagonal { get; set; }
        public double Diagonal2 { get; set; }

        public override double GetArea()
        {
            return (Diagonal * Diagonal2) / 2;
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X), (int)(Position.Y - Diagonal2 / 2));
        }

        public override void Draw(Graphics gr)
        {
            Pen brush = new Pen(Color);
            Point[] points = { new Point(Position.X, Position.Y), new Point(Position.X - (int)Diagonal / 2, Position.Y - (int)Diagonal2 / 2), 
                new Point(Position.X, Position.Y - (int)Diagonal2), new Point(Position.X + (int)Diagonal / 2, Position.Y-(int)Diagonal2/2) };
            gr.DrawPolygon(brush, points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
