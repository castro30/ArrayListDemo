using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArratListClassDemo
{
    class ForEachClass
    {
        int[] numList = { 10, 20, 30, 40 };

        public void SayHi()
        {
            Console.WriteLine("Hello");
        }

        public void PrintNumbers()
        {
            foreach (int item in numList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
