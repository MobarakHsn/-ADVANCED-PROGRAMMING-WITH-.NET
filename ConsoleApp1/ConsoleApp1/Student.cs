using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }
        public double Cgpa { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Name " + Name);
            Console.WriteLine("Id " + Id);
            Console.WriteLine("Cgpa " + Cgpa);
            Console.WriteLine("Dob " + Dob);
        }
    }
}
