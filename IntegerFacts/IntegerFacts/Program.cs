using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IntegerFacts
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 0, minValue = 0, sum = 0, size = 0;
            double average = 0.00;
            int[] list = new int[10];
            fillArray(list, ref size);
            WriteLine();
            calculateStatstics(list, ref maxValue, ref minValue, ref sum, ref average, ref size);
            WriteLine("Highest value: {0}", maxValue);
            WriteLine("Lowest value: {0}", minValue);
            WriteLine("Sum of all values: {0}", sum);
            WriteLine("Average of all values: {0}", average);
        }

        static void fillArray(int[] list, ref int size)
        {
            for (int i = 0; i <= 9; ++i)
            {
                string userInput;
                Write("Enter a number for your array or enter 999 to quit: ");
                userInput = ReadLine();
                int intInput;
                if(int.TryParse(userInput, out intInput))
                {
                    if (intInput != 999)
                    {
                        list[i] = intInput;
                        size += 1;
                    }
                    else
                        break;
                } else
                {
                    WriteLine("Error, invalid integer input, try again.");
                    --i;
                }
            }
        }

        static void calculateStatstics (int[] list, ref int maxValue, ref int minValue, ref int sum, ref double average, ref int size)
        {
            if (size == 0)
            {
                WriteLine("You did not enter any values, there are no statistics to show.");
            }
            else
            {
                Array.Sort(list);
                for (int i = 0; i < 10; ++i)
                {
                    sum += list[i];
                }
                average = (sum / size);
                maxValue = list[9];
                minValue = list[list.Length - size];
                
            }
        }
    }
}
