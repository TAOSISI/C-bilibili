using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu["Math"] = 90;
            stu["Math"] = 100;
            var mathScore = stu["Math"];
            Console.WriteLine(mathScore == null);
            Console.WriteLine(mathScore);
            Console.ReadKey();
        }
    }
    class Student
    {
        private Dictionary<string, int> scoreDictionary = new Dictionary<string, int>();

        //声明索引器，一般运用于集合中
        public int? this[string subject]//可空的int类型
        {
            get
            {
                /* return the specified index here */
                if (this.scoreDictionary.ContainsKey(subject))
                {
                    return this.scoreDictionary[subject];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                /* set the specified index to value here */
                if (value.HasValue==false)
                {
                    throw new Exception("Score cannot be null.");
                }
                if (this.scoreDictionary.ContainsKey(subject))
                {
                    this.scoreDictionary[subject] = value.Value;//对于可空类型，.Value才是真正的值
                }
                else
                {
                    this.scoreDictionary.Add(subject, value.Value);
                }
            }
        }
    }
}
