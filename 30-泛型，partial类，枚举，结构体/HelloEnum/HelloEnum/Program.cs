using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Level = Level.Employee;
            person.Name = "Timothy";
            person.Skill = Skill.Drive | Skill.Cook | Skill.Program | Skill.Teach;//枚举类型的比特位用法
            Console.WriteLine(person.Skill);
            Console.WriteLine((person.Skill &Skill.Cook)>0);

            Person boss = new Person();
            boss.Level = Level.Boss;

            Console.WriteLine(boss.Level>person.Level);
            Console.WriteLine((int)Level.Employee);
            Console.WriteLine((int)Level.Boss);
            Console.ReadKey();
        }
    }
    enum Skill
    {
        Drive=1,
        Cook=2,
        Program=4,
        Teach=8,
    }
    enum Level
    {
        Employee,
        Manager,
        Boss,
        BigBoss,
    }
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Level Level { get; set; }
        public Skill Skill { get; set; }
    }
}
