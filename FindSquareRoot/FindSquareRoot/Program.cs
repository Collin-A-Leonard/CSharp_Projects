using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FindSquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            double sqrt;
            Write("Enter a number to find the square root of: ");
            if (!double.TryParse(ReadLine(), out num))
            {
                WriteLine("Invalid entry, number input set to 0.");
                sqrt = 0;
            }
            else if (num < 0)
            {
                try
                {
                        ApplicationException ape = new ApplicationException("Number can't be negative.");
                        throw (ape);
                }
                catch (ApplicationException e)
                {
                    WriteLine(e.Message);
                    sqrt = 0;
                }
            }
            else
            {
                sqrt = Math.Sqrt(num);
            }
            WriteLine("The square root of your number is: {0}", sqrt);
        }
    }
}
