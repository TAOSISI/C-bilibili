using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExample2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Student
    {
        private int age;
        public int Age {
            get
            {
                return age;
            }
            set
            {
                age = value;
                this.CalcumateCanWork();
            }
        }
        private bool canWork;
        public bool CanWork
        {
            get { return canWork; }
        }
        private void CalcumateCanWork()
        {
            if (this.age >= 16)
            {
                this.canWork = true;
            }
            else
            {
                this.canWork = false;
            }
        }
    }
}
