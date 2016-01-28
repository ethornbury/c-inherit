using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritEx
{
    class Student : Person
    {
        public int StudentID { get; set; }

        public Student(string fn, string ln, int id):base(fn, ln)
        {

        }

    }
}
