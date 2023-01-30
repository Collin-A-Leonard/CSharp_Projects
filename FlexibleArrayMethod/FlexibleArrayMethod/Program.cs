using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FlexibleArrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5, 10, 15 }; // added = 30
            int[] array2 = { 5, 10, 15, 20 }; // added = 50
            int[] array3 = { 5, 10, 15, 20, 25 }; // added = 75
            calculateTotal(array1);
            WriteLine();
            calculateTotal(array2);
            WriteLine();
            calculateTotal(array3);
        }

        static void calculateTotal(int[] list)
        {
            int total = 0;
            Write("The numbers in the array are: ");
            for (int i = 0; i < list.Length; ++i)
            {
                if (i < (list.Length - 1))
                    Write(list[i] + ", ");
                else if ((i == list.Length) && (list.Length > 1))
                    Write("and " + list[i] + ".");
                else
                    Write("{0}.", list[i]);
                total += list[i];
            }
            WriteLine();
            WriteLine("The sum of the array is: {0}", total);
        }
    }
}
