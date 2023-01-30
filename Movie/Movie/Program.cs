using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            displayMovie("Halloween", 120);
            WriteLine();
            displayMovie("Shrek 2");
        }

        static void displayMovie(String movie, int runTime = 90)
        {
            WriteLine("The movie is {0}, and it is {1} minutes long.", movie, runTime);
        }
    }
}
