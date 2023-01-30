using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
class StudentGradeDemo
{
    static void Main(string[] args)
    {
        try
        {
            ReportCard cardOne = new ReportCard("Fred", 98, 76);
            WriteLine(cardOne.ToString());
        }
        catch (Exception e)
        {
            WriteLine(e.Message);
        }
        WriteLine();
        try
        {
            ReportCard cardTwo = new ReportCard("Gary", 104, 98);
            WriteLine(cardTwo.ToString());
        }
        catch (Exception e)
        {
            WriteLine(e.Message);
        }
        WriteLine();
        try
        {
            ReportCard cardThree = new ReportCard("Susan", 76, -49);
            WriteLine(cardThree.ToString());
        }
        catch (Exception e)
        {
            WriteLine(e.Message);
        }
        WriteLine();
    }
}

class ReportCard
{
    private string studentName;
    private double midtermGrade;
    private double finalExam;
    private string letterGrade;

    public ReportCard(string name, double midterm, double final)
    {
        studentName = name;
        if (midterm < 0 || midterm > 100)
        {
            ArgumentException ae = new ArgumentException("Error, midterm grade must be less than 100 and more than 0.");
            throw (ae);
        }
        else
        {
            midtermGrade = midterm;
        }
        if (final < 0 || final > 100)
        {
            ArgumentException ae = new ArgumentException("Error, final exam grade must be less than 100 and more than 0.");
            throw (ae);
        }
        else
        {
            finalExam = final;
        }
        letterGrade = calculateGrade(midterm, final);
    }

    private string calculateGrade(double first, double second)
    {
        string letterGrade = "";
        double grade = ((first + second) / 2);
        if (grade >= 90 && grade <= 100)
        {
            letterGrade = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letterGrade = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letterGrade = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letterGrade = "D";
        }
        else if (grade < 60)
        {
            letterGrade = "F";
        }
        return letterGrade;
    }

    public override string ToString()
    {
        //return "Name: " + StudentName + ", Midterm Grade: " + MidtermGrade.ToString("P") + ", Final Exam Grade: " + FinalExam.ToString("P") + ", Letter Grade: " + LetterGrade + ".";
        return String.Format("Name: {0}, Midterm Grade: {1}%, Final Exam Grade {2}%, Letter Grade: {3}.", studentName, midtermGrade, finalExam, letterGrade);

    }
}

