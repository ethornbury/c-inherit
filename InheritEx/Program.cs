using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritEx
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person("Joe", "Bloggs");
            Person p1 = new Person("Joe1", "Bloggs2");

            Console.WriteLine(p.ToString());
            Console.WriteLine(p1.ToString());
            Console.WriteLine("******");

            Student s = new Student("Emer", "Thornbury", 12);
            Student s1 = new Student("Dean", "McGuiness", 14);
            Console.WriteLine(s.ToString());
            Console.WriteLine(s1.ToString());

            Console.WriteLine("******");

            Console.ReadLine();
        }
    }
}
