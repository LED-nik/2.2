using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Theater
{
   
    
    class Program
        {
        public class Person
            {
                public string name;
                public string surname;
                public Person(string _name, string _surname)
                {
                    name = _name;
                    surname = _surname;
                }
                public string output()
                {
                    return name + " " + surname;
                }
            }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter surname");
            string surname = Console.ReadLine();
            Person user = new Person(name, surname);
            Console.WriteLine(user.output());
            Console.ReadKey();
        }
    }
}
