using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdmissionModularized
{
    class Program
    {
        static void Main(string[] args)
        {
            string gpaString;
            string testScoreString;
            Write("Enter your numeric high school grade point average: ");
            gpaString = ReadLine();
            double gpa = Convert.ToDouble(gpaString);
            Write("Enter your admission test score: ");
            testScoreString = ReadLine();
            double testScore = Convert.ToDouble(testScoreString);
            string schoolChoice = reviewAdmission(gpa, testScore);
            WriteLine(schoolChoice);
        }

        static string reviewAdmission(double gpa, double testScore)
        {
            if ((gpa >= 3.0 && testScore >= 60) || (gpa < 3.0 && testScore >= 80))
            {
                return "Accept";
            }
            else
                return "Reject";
        }
    }
}
