using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKiller killer = new WarmKiller();
            killer.Kill();

            var wk=killer as WarmKiller;//强制类型转换
            wk.Love();

            Console.ReadKey();
        }
    }
    interface IGentleman
    {
        void Love();
    }
    interface IKiller
    {
        void Kill();
    }
    class WarmKiller : IGentleman,IKiller
    {

        public void Love()
        {
            Console.WriteLine("I will love you for ever ...");
        }

        void IKiller.Kill()
        {
            Console.WriteLine("Let me kill the enemu ...");
        }
    }
}
