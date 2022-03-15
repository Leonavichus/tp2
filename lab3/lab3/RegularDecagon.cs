using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab3
{
    class RegularDecagon : Figure
    {
        private int D = 60;
        private double OffSet = 0;
        public double Storona { get; set; }

        public override double GetArea()
        {
            return 5 / 2 * Math.Pow(Storona, 2) * Math.Sqrt(5 + 2 * Math.Sqrt(5));
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X), (int)(Position.Y));
        }

        public override void Draw(Graphics gr)
        {
            Pen brush = new Pen(Color);
            List<Point> p = new List<Point>();

            for (int i = 0; i < 360; i += 36)
            {
                var kr = D / 2;

                double rad = (double)i / 180 * 3.14;
                int x = (int)(kr * Math.Cos(rad + OffSet));
                int y = (int)(kr * Math.Sin(rad + OffSet));

                p.Add(new Point(x + kr*5, y + kr*5));
            }

            gr.DrawPolygon(brush, p.ToArray());
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
