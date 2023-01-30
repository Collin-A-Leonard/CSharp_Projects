using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SalesTransactionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesTransaction example1 = new SalesTransaction("Gary", 1200);
            SalesTransaction example2 = new SalesTransaction("Susan", 800, 0.05);
            SalesTransaction example3 = new SalesTransaction("Phillip");
            WriteLine("Sales person 1 is {0} and has made {1} in sales, has a commission rate of {2}, and has made {3} in commission.\n",
     example1.Name, example1.SalesAmount.ToString("C"), example1.Commission_rate.ToString("P0"), example1.Commission.ToString("C"));
            WriteLine("Sales person 2 is {0} and has made {1} in sales, has a commission rate of {2}, and has made {3} in commission.\n",
    example2.Name, example2.SalesAmount.ToString("C"), example2.Commission_rate.ToString("P0"), example2.Commission.ToString("C"));
            WriteLine("Sales person 3 is {0} and has made {1} in sales, has a commission rate of {2}, and has made {3} in commission.\n",
                example3.Name, example3.SalesAmount.ToString("C"), example3.Commission_rate.ToString("P0"), example3.Commission.ToString("C"));
            SalesTransaction addedExamples = example1 + example2;
            WriteLine("The sales of {0} amount to {1}.\n", addedExamples.Name, addedExamples.SalesAmount.ToString("C"));

        }
    }

    class SalesTransaction
    {
        private string name;
        private double salesAmount;
        private double commission;
        private readonly double commission_rate;

        public string Name { get; set; }
        public double SalesAmount { get; set; }
        public double Commission { get; set; }
        public double Commission_rate { get; }

        public SalesTransaction(string name, double sales, double rate)
        {
            Name = name;
            SalesAmount = sales;
            Commission_rate = rate;
            Commission = sales * Commission_rate;
        }

        public SalesTransaction(string name, double sales)
        {
            Commission_rate = 0;
            Name = name;
            SalesAmount = sales;
        }

        public SalesTransaction(string name)
        {
            Name = name;
            SalesAmount = 0;
            Commission = 0;
            Commission_rate = 0;
        }

        public static SalesTransaction operator+(SalesTransaction first, SalesTransaction second)
        {
            string newName = first.Name + " and " + second.Name;
            double newSales = first.SalesAmount + second.SalesAmount;
            return (new SalesTransaction(newName, newSales));
        }
    }
}
