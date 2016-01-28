using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritEx
{
    class Person
    {
        // this is my base class
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public Person(string fn, string ln)
        {
            Firstname = fn;
            Lastname = ln;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nFirstname: ");
            sb.Append(Firstname);
            sb.Append("\nLastname: ");
            sb.Append(Lastname);
            return sb.ToString();

        }
    }
}
