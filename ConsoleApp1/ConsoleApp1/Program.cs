using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] nums = new int[] {10,12,50,60,70 };
            var filter = (from n in nums where n > 40 select n).ToArray();
            foreach (var i in filter)
            {
                Console.WriteLine(i);
            }*/
            List<Student> students = new List<Student>();
            students.Add(new Student()
            {
                Id = 1,
                Name = "A",
                Dob="11/10/1997",
                Cgpa=2.5
            });
            students.Add(new Student()
            {
                Id = 2,
                Name = "B",
                Dob = "11/9/2000",
                Cgpa = 2.9
            });

            students.Add(new Student()
            {
                Id = 3,
                Name = "C",
                Dob = "11/10/1998",
                Cgpa = 3.4
            });
            students.Add(new Student()
            {
                Id = 4,
                Name = "D",
                Dob = "11/10/2003",
                Cgpa = 3.7
            });
            students.Add(new Student()
            {
                Id = 5,
                Name = "E",
                Dob = "05/06/2022",
                Cgpa = 3.9
            });
            Console.WriteLine("***Cgpa>3***");
            var A= (from n in students where n.Cgpa > 3 select n).ToArray();
            foreach(var i in A)
            {
                i.ShowInfo();
                Console.WriteLine();
            }

            Console.WriteLine("***Cgpa>2.5 && Id>3***");
            var B = (from n in students where n.Cgpa > 2.5 && n.Id>3 select n).ToArray();
            foreach (var i in B)
            {
                i.ShowInfo();
                Console.WriteLine();
            }

            Console.WriteLine("***Age>18***");
            var C = (from n in students where DateTime.Parse(n.Dob).Year<2006 select n).ToArray();
            foreach (var i in C)
            {
                i.ShowInfo();
                Console.WriteLine();
            }
            Console.WriteLine("***Only student id and cgpa***");
            //var flt = (from n in students select new { Id = n.Id, Cgpa = n.Cgpa }).FirstOrDefault();
            var flt = (from n in students select new { Id = n.Id, Cgpa = n.Cgpa }).ToArray();
            //Console.WriteLine(flt.Cgpa);'
            foreach (var i in flt)
            {
                Console.WriteLine(i.Id);
                Console.WriteLine(i.Cgpa);
                Console.WriteLine();
            }


            Console.WriteLine("***Only student id and dob with age<16***");
            //var flt = (from n in students select new { Id = n.Id, Cgpa = n.Cgpa }).FirstOrDefault();
            var E = (from n in students where DateTime.Parse(n.Dob).Year > 2007 select new { Id = n.Id, Dob = n.Dob }).ToArray();
            //Console.WriteLine(flt.Cgpa);'
            foreach (var i in E)
            {
                Console.WriteLine(i.Id);
                Console.WriteLine(i.Dob);
                Console.WriteLine();
            }
        }
    }
}
