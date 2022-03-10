using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    internal class Program
    {
        public static Figure[] figures = 
        {
            new Rectangle()
            {

            }
        };

        static void Main(string[] args)
        { 
            Console.WriteLine("Лабораторная работа №3 - Полиформизм");
            Console.WriteLine("Выполнил - Леонавичус Даниил");

            Figure f = new Rectangle()
            {
                Name = "Квадрат",
                Color = System.Drawing.Color.DarkRed,
                Position = new System.Drawing.Point(30,30),
                Width = 50, Height = 50
            };

            Console.WriteLine("Фигура: " + f.Name);
            Console.WriteLine("Площадь: " + f.GetArea());
            Console.WriteLine("Цвет: " + f.Color);
            Console.WriteLine("Положение фигуры: " + f.Position);
            Console.WriteLine("Координаты центра: " + f.GetCenter());

            Form frm = new Form()
            {
                Text = "Лабораторная работа №3 - Полиформизм",
                Size = new System.Drawing.Size(800,600),
                StartPosition = FormStartPosition.CenterScreen
            };

            Application.Run(frm);
        }
    }
}
