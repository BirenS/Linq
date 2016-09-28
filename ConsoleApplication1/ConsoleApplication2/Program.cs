using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Database1Entities de = new Database1Entities();
            var q = from c in de.Students
                    select c;

            foreach(var a in q)
            {
                Console.WriteLine(a.Name);

            }
            Console.ReadLine();

            Student s1 = new Student() { Id = 4, Name = "Ronit", Dept = "CE" };
            de.Students.Add(s1);
            de.SaveChanges();
        }
    }
}
