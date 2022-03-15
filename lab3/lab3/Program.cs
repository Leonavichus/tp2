using System;
using System.Windows.Forms;


namespace lab3
{
    internal class Program
    {
        public static Figure[] figures =
        {
            new Rectangle()
            {
                Name = "Квадрат №1",
                Color = System.Drawing.Color.DarkRed,
                Position = new System.Drawing.Point(30,200),
                Width = 50, Height = 50
            },
            new Rectangle()
            {
                Name = "Прямоугольник №1",
                Color = System.Drawing.Color.Blue,
                Position = new System.Drawing.Point(200,200),
                Width = 100, Height = 50
            },
            new Circle()
            {
                Name = "Круг №1",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(60,100),
                Radius = 20
            },
            new Triangle()
            {
                Name = "Треугольник №1",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(130,70),
                Osnov = 100, Height=50

            },
            new Trapezoid()
            {
                Name = "Трапеция №1",
                Color = System.Drawing.Color.Red,
                Position = new System.Drawing.Point(245,55),
                Osnov = 50, Height=20, Osnov2 = 20
            },
            new Rhombus()
            {
                Name = "Ромб №1",
                Color = System.Drawing.Color.BlueViolet,
                Position = new System.Drawing.Point(355,70),
                Diagonal = 100,Diagonal2 =50
            },
            new Parallelogram()
            {
                Name = "Параллелограмм №1",
                Color = System.Drawing.Color.HotPink,
                Position = new System.Drawing.Point(470,60),
                Storona = 100, Height = 50
            },
            new RegularPentagon()
            {
                Name = "Правильный пятиугольник №1",
                Color = System.Drawing.Color.IndianRed,
                Position = new System.Drawing.Point(25,25)
            },
            new RegularDecagon()
            {
                Name = "Правильный десятиугольник №1",
                Color = System.Drawing.Color.Purple,
                Position = new System.Drawing.Point(150,150),
            }

        };

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №3 - Полиформизм");
            Console.WriteLine("Выполнил - Леонавичус Даниил");

            Form frm = new Form()
            {
                Text = "Лабораторная работа №3 - Полиформизм",
                Size = new System.Drawing.Size(800, 600),
                StartPosition = FormStartPosition.CenterScreen
            };

            frm.Paint += Frm_Paint;

            Application.Run(frm);
        }

        private static void Frm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in figures)
            {
                f.Draw(e.Graphics);
            }
        }
    }
}
