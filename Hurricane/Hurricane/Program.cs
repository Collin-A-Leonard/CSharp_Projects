using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CAT5 = 157;
            const int CAT4 = 130;
            const int CAT3 = 111;
            const int CAT2 = 96;
            const int CAT1 = 74;
            string userInput;
            int windSpeed;
            Write("Please enter the wind speed: ");
            userInput = ReadLine();
            windSpeed = Convert.ToInt32(userInput);
            WriteLine();
            if (windSpeed >= CAT5)
                WriteLine("Category 5 hurricane");
            else if (windSpeed >= CAT4)
                WriteLine("Category 4 hurricane");
            else if (windSpeed >= CAT3)
                WriteLine("Category 3 hurricane");
            else if (windSpeed >= CAT2)
                WriteLine("Category 2 hurricane");
            else if (windSpeed >= CAT1)
                WriteLine("Category 1 hurricane");
            else
                WriteLine("These wind speeds don't qualify as a hurricane.");
        }
    }
}
