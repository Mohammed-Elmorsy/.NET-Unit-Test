using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_test_lab1
{
    public class Calculations
    {
        public int Sum(int x, int y)
        {
            if (x > y)
                return x + y;

            return 0;
        }
        //-----------------------------------------------
        public string Sum(string a, string b)
        {
            if ((a != null && a != "") && (b != null && b != ""))
                return a + " " + b;

            return null;
        }
        //-------------------------------------------------
        public int Subtract(int x, int y)
        {
            if (x > y) return x - y;
            else if (y > x) return y - x;
            else return 0;
        }
        //-----------------------------------------------
        public static double CMToInch(double cm)
        {
            if (cm > 0) return cm / 2.5;

            return 0;
        }
        //--------------------------------------------------
        public double Divide(double x, double y)
        {
            if (y == 0) return 0;

            return x / y;
        }
        //------------------------------------------------------
        public List<int> GetOdd(List<int> numbers)
        {
            if (numbers == null) return null;

            List<int> odd_numbers = new List<int>();

            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                    odd_numbers.Add(number);
            }

            return odd_numbers;
        }
    }
}
