using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DeliveryCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] validZips = new int[10] { 45420, 45421, 45422, 45423, 45424, 45425, 45426, 45427, 45428, 45429 };
            int[] zipPrices = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string userInput;
            Write("Enter your zip code: ");
            userInput = ReadLine();
            int userZip = Convert.ToInt32(userInput);
            bool isValidZip = false;
            for (int i = 0; i < validZips.Length; ++i)
            {
                if (userZip == validZips[i])
                {
                    WriteLine("It costs {0} to deliver to {1} zip code.", zipPrices[i].ToString("C"), validZips[i]);
                    isValidZip = true;
                }
            }
            if (!isValidZip)
            {
                WriteLine("Sorry, you're not in our delivery zone.");
            }
        }
    }
}
