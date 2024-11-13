using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_IV
{
    internal class MyOperation
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);

        }

        public int Sum1(int a, int b)
        {
            return a + b;
        }

        public void Sum(float a,float b)
        {
            Console.Write(a + b);
        }
        
        public void Sum(int a, int b,int c)
        {
            Console.WriteLine(a + b+c);
        }
    }
}
