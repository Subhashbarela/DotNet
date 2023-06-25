using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_BacisConcept
{
    public class Student
    {
        public int id;
        public string name;
        public int age;
        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public void Show()
        {
            Console.WriteLine(" id : " + id);
            Console.WriteLine(" name : " + name);
            Console.WriteLine(" age : " + age);
        }

    }
}
