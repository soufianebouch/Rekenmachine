using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekenamchineLogica
{
    public class Class1
    {
        public static double Berekenen(double getal1, double getal2, string operat)
        {
            double result = 0;
            switch (operat)
            {
                case "+":
                    result = getal1 + getal2;
                    break;
                case "-":
                    result = getal1 - getal2;
                    break;
                case "*":
                    result = getal1 * getal2;
                    break;
                case "/":
                    result = getal1 / getal2;
                    break;
            }
            return result;
        }
    }
}
