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
                Position = new System.Drawing.Point(30,30),
                Width = 50, Height = 50
            },
            new Rectangle()
            {
                Name = "Квадрат №2",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(60,100),
                Width = 100, Height = 100
            },
             new Rectangle()
            {
                Name = "Прямоугольник №1",
                Color = System.Drawing.Color.Blue,
                Position = new System.Drawing.Point(200,200),
                Width = 100, Height = 50
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
