using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SubscriptExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] values = new double[10] { 12.4, 34.23, 0.987, 8.76, 1.497, 0.7689, 76.108, 45.0, 987.18, 3.98 };
            try
            {
                int exit = 999;
                int arrChoice;
                Write("Enter a number for the array index (0-9) or 999 to quit: ");
                arrChoice = Convert.ToInt32(ReadLine());

                while (arrChoice != exit)
                {
                    WriteLine("The array value is {0}", values[arrChoice]);
                    Write("Enter a number for the array index (0-9) or 999 to quit: ");
                    arrChoice = Convert.ToInt32(ReadLine());
                }
            } catch (IndexOutOfRangeException e)
            {
                WriteLine("\nError, chosen array index out of range.");
            }
        }
    }
}
