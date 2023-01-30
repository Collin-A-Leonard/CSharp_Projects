using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CountVowelsModularized
{
    class Program
    {
        static void Main(string[] args)
        {
            int vowelCount = 0;
            WriteLine("This program will count the number of vowels in a string.");
            WriteLine();
            Write("Enter your string: ");
            String userInput = Console.ReadLine();
            vowelCount = countVowels(userInput);
            WriteLine();
            WriteLine("Number of vowels in your string is: {0}", vowelCount);
        }

        static int countVowels(string input)
        {
            int vowelCount = 0;
            for(int i = 0; i < input.Length; ++i)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                    ++vowelCount;
            }
            return vowelCount;
        }
    }
}
