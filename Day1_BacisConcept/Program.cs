using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_BacisConcept
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Class And Object \n2: Tyeps Of Variable \n3: Types Of Method ");
            Console.WriteLine("Enter the choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Student s = new Student(101, "subhash", 26);
                        s.Show();
                        break;
                    }
                case 2:
                    {
                        VariableClass v = new VariableClass();
                        Console.WriteLine("Int Value : " + v.IntMethod(10, 20));
                        Console.WriteLine("Double Value " + v.DoubleMethod(10.5, 2.4));
                        Console.WriteLine("Name is : " + v.StringMethod());
                        break;
                    }
                case 3:
                    {
                        MethodClass methodClass = new MethodClass();
                        methodClass.NormalMethod();
                        MethodClass.StaticMethod();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid choice ");
                        break;
                    }
            }
            Console.ReadLine();
        }
    
    
    }
}
