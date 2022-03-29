using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4주차
{
    class Program
    {
        static void SumAvg(int[] abc)
        {
            int s = 0;
            for (int i = 0; i < abc.Length; i++)
            {
                s += abc[i];
            }
            Console.WriteLine("합 : " + s);
            Console.WriteLine("평균 : " + s / abc.Length);
        }
        static void Main(string[] args)
        {
            int[] abc = { 1, 2, 3, 4, 5 };
            SumAvg(abc);

        }
    }
}
