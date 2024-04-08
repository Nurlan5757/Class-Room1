using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Models
{
    internal class Student
    {
        static int count = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(string name, string surname)
        {
             
            Name = Capitalize(name);
            Surname = Capitalize(surname);
            Id = count++;
        }

        public string GetInfo()
        {
            return $"{Name} {Surname}";
        }


        public static string Capitalize( string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return name;
            }

            return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
        }

      


    }
}
