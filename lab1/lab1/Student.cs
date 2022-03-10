using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Student
    {
        public string Name { get; set; }
        public string NameFaculty { get; set; }
        public int  Age { get; set; }
        public int Kurs { get; set; }
        public long RecordBookNumber { get; set; }

        public void Show() {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", Name, NameFaculty, Age, Kurs, RecordBookNumber);
        }

        public void AddStud(Student x)
        {
            Name += x.Name;
            NameFaculty += x.NameFaculty;
            Age += x.Age;
            Kurs += x.Kurs;
            RecordBookNumber += x.RecordBookNumber;
        }
        public void AddStud1(Student x, Student y)
        {
            Name += (x.Name + y.Name);
            NameFaculty += (x.NameFaculty + y.NameFaculty);
            Age += (x.Age + y.Age);
            Kurs += (x.Kurs + y.Kurs);
            RecordBookNumber += (x.RecordBookNumber + y.RecordBookNumber);
        }
    }
}
