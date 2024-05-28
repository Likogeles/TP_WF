using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.Models
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Student() { }

        public Student(string name, string surname, int age) {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override string ToString()
        {
            return Surname + " " + Name + ": " + Age.ToString();
        }
    }
}
