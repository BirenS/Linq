using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext cdc = new DataClasses1DataContext();
          var q = from c in cdc.GetTable<Student>()
                    select c;
            foreach(var a in q)
            {
                Console.WriteLine(a.Name);
            }
            Console.ReadLine();

            Student s1= new Student(){Id=3, Name="Ronit", Dept="CE"};
            cdc.Students.InsertOnSubmit(s1);
            cdc.SubmitChanges();

            foreach (var a in q)
            {
                Console.WriteLine(a.Name);
            }
            Console.ReadLine();

        }
    }
}
