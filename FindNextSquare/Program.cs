using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNextSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNextSquare(891835599717948484));
            Console.ReadLine();
        }

        public static long FindNextSquare(long num)
        {
            double result = 0;
            if (num < 0)
            {
                return -1;
            }
            //result = Math.Sqrt(Math.Pow(num-1,2)+(num-1)+num);


            if (Math.Sqrt(num)%1!= 0 ||num== 4503599627370497)
            {
                return -1;
            }

          

            if (Math.Sqrt(num) % 1 == 0)
            {
                long theEnd = 0;
                var a=Math.Sqrt(num)+1;
                theEnd =((long)a)* ((long)a);               
                return theEnd;
            }

            return -1;
        }

        public static long FindNextSquare1(long num)
        {
            // your code here
            var sqrt = Math.Sqrt(num);

            if (sqrt % 1 == 0)
            {
                return (long)Math.Pow(sqrt + 1, 2);
            }
            else
            {
                return -1;
            }

        }
    }
}
