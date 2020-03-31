using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4, 5 };
            ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };
            Console.WriteLine(Sum(nums1));
            Console.WriteLine(Sum(nums2));
            var roc = new ReadOnlyCollection(nums1);
            foreach(var n in roc)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
        static int Sum(ICollection nums)
        {
            int sum = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
            }
            return sum;
        }
    }
    class ReadOnlyCollection:IEnumerable
    {
        private int[] _array;
        public ReadOnlyCollection(int[] array)
        {
            _array = array;
        }
        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
        public class Enumerator : IEnumerator//成员类
        {
            private ReadOnlyCollection _collection;
            private int _head;
            public Enumerator(ReadOnlyCollection collection)
            {
                _collection = collection;
                _head = -1;
            }
            public object Current
            {
                get
                {
                    object o = _collection._array[_head];//装箱
                    return o;
                }
            }

            public bool MoveNext()
            {
                if (++_head<_collection._array.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                _head = -1;
            }
        }
    }
}
