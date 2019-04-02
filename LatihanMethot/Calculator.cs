using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    public class Calculator
    {
        public int penjumlah(int a, int b)
        {
            return a + b;
        }
        //overload method
        public int penjumlah(int a, int b, int c)
        {
            return a + b + c;
        }

        public int pengurangan(int a, int b)
        {
            return a - b;
        }
        //overload static
        public static int perkalian(int a, int b)
        {
            return a * b;
        }
    }
}
