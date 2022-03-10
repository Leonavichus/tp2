using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №2 - Наследование");
            Console.WriteLine("Выполнил - Леонавичус Даниил");

            Rectangle a = new Rectangle()
            {
                Name = "Прямоугольник A",
                Width = 15.2,
                Height = 13.7
            };

            Rectangle b = new Rectangle()
            {
                Name = "Прямоугольник B",
                Width = 5.1,
                Height = 2.8
            };

            Circle c = new Circle()
            {
                Name = "Круг",
                Radius = 4
            };

            Square q = new Square() 
            { 
                Name = "Квадрат", 
                Storona = 7 
            };

            Triangle tri = new Triangle()
            {
                Name = "Треугольник",
                Osnov = 8,
                Height = 3
            };

            Trapezoid ta = new Trapezoid()
            {
                Name = "Трапеция",
                Osnov = 3,
                Osnov2 = 1,
                Height = 2
            };

            Rhombus rh = new Rhombus()
            {
                Name = "Ромб",
                Diagonal = 3,
                Diagonal2 = 1
            };

            Parallelogram par = new Parallelogram()
            {
                Name = "Параллелограмм",
                Storona = 7,
                Height = 4
            };

            RegularPentagon rp = new RegularPentagon()
            {
                Name = "Правильный пятиугольник",
                Storona = 7
            };

            RegularDecagon rd = new RegularDecagon()
            {
                Name = "Правильный десятиугольник",
                Storona = 7
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", a.Name);
            Console.WriteLine("Площадь фигуры: {0}", a.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", b.Name);
            Console.WriteLine("Площадь фигуры: {0}", b.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", c.Name);
            Console.WriteLine("Площадь фигуры: {0}", c.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", q.Name);
            Console.WriteLine("Площадь фигуры: {0}", q.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", ta.Name);
            Console.WriteLine("Площадь фигуры: {0}", ta.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", rh.Name);
            Console.WriteLine("Площадь фигуры: {0}", rh.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", par.Name);
            Console.WriteLine("Площадь фигуры: {0}", par.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", rp.Name);
            Console.WriteLine("Площадь фигуры: {0}", rp.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", rd.Name);
            Console.WriteLine("Площадь фигуры: {0}", rd.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", tri.Name);
            Console.WriteLine("Площадь фигуры: {0}", tri.GetArea());
        }
    }
}
