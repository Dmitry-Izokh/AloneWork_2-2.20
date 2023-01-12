using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AloneWork_2_2._20.Models
{
    static class Calculator
    {
        //public static int Clear(int c)
        //{
        //   return 0;
        //}

        public static int SignReplacement(int a)
        {
            if (a > 0 || a<0)
                return -a;
            else
                return 0;            
        }

        public static int Division(int a, int b)
        {
            double A = Convert.ToDouble(a);
            double B = Convert.ToDouble(b);
            double c = A / B;
            return (int)c;
        }

        public static int Multiplication(int a, int b)
        {
            int c = a * b;
            return c;
        }

        public static int Subtraction(int a, int b)
        {
            int c = a - b;
            return c;
        }

        public static int Addition(int a, int b)
        {
            int c = a + b;
            return c;
        }

        internal static object Clear(double nomber3)
        {
            throw new NotImplementedException();
        }
    }
}
