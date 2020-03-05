using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //计算机语言中的操作符是不能脱离与他关联的数据类型的
            int x = 5;
            int y = 4;
            int z = x / y;
            Console.WriteLine(z);

            double a = 5.0;
            double b = 4.0;
            double c = a / b;
            Console.WriteLine(c);
            Console.ReadKey();
            Person person1 = new Person();
            Person person2 = new Person();
            person1.Name = "Deer";
            person2.Name = "Deer's wife";
            List<Person> nation = person1 + person2;
            foreach (var p in nation)
            {
                Console.WriteLine(p.Name);
            }
            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name;
        public static List<Person> operator +(Person p1, Person p2)
        {
            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(p2);
            for (int i = 0; i < 11; i++)
            {
                Person child = new Person();
                child.Name = p1.Name + " & " + p2.Name + "'s child";
                people.Add(child);
            }
            return people;
        }
    }
}
