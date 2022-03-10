using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная №1 - Инкапсуляция");
            Console.WriteLine("Выполнил - Леонавичус Даниил");

            Complex a = new Complex() { Real = 3, Imag = 0.5 };
            Complex b = new Complex() { Real = 2, Imag = 0.8 };
            Complex c = new Complex() { Real = 4, Imag = 0.4 };
            Complex d = new Complex() { Real = 2, Imag = 0.6 };

            a.Add(b);
            b.Substract(a);
            c.Multiply(d);
            d.Divide(c);

            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);
            Console.WriteLine("c = {0} + {1}i", c.Real, c.Imag);
            Console.WriteLine("d = {0} + {1}i", d.Real, d.Imag);
            /*---------------------------------------------------*/

            Student e = new Student() { Name = "Ivan", NameFaculty = "Icit", Age = 21, Kurs = 3, RecordBookNumber = 23451233211 };
            Student f = new Student() { Name = "Ilia", NameFaculty = "Icit", Age = 20, Kurs = 2, RecordBookNumber = 134123512341 };
            Console.WriteLine("\nЗначения:");
            Console.WriteLine("Name\tFaculty\tAge\tKurs\tRecordBookNumber");
            e.Show(); f.Show();
            Console.WriteLine("Cумма:");
            e.AddStud(f);
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", e.Name, e.NameFaculty, e.Age, e.Kurs, e.RecordBookNumber);
            /*---------------------------------------------------*/

            Student v = new Student() { Name = "Dan", NameFaculty = "Icit", Age = 21, Kurs = 3, RecordBookNumber = 23451233211 };
            Student x = new Student() { Name = "Ilia", NameFaculty = "Icit", Age = 20, Kurs = 2, RecordBookNumber = 134123512341 };
            Student k = new Student() { Name = "Kirill", NameFaculty = "Icit", Age = 22, Kurs = 2, RecordBookNumber = 3378123512343 };
            Console.WriteLine("\nЗначения:");
            Console.WriteLine("Name\tFaculty\tAge\tKurs\tRecordBookNumber");
            v.Show(); x.Show(); k.Show();
            Console.WriteLine("Cумма:");
            v.AddStud1(x,k);
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", v.Name, v.NameFaculty, v.Age, v.Kurs, v.RecordBookNumber);
        }
    }
}
