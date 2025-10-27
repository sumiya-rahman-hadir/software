using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsRefOut
{
    internal class Program
    {
     public static int sum(int x, int y)
        {
            return x+y;
        }
        public static int sumParam(params int[] nunmList)
        {
            int total = 0;
            foreach (int num in numList) ;

        }
        static void Main(string[] args)
        {
           int x= sum(4, 5);
            Console.WriteLine("Sum is:" + x);
            Console.ReadLine();
        }
    }
}
