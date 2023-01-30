using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car honda = new Car("Civic", 30);
            Car ford = new Car("F150");
            WriteLine("The {0} gets {1} miles per gallon.\n", honda.Model, honda.Mpg);
            WriteLine("The {0} gets {1} miles per gallon.\n", ford.Model, ford.Mpg);
            honda++;
            ford++;
            WriteLine("After overloaded operator, the {0} gets {1} miles per gallon.\n", honda.Model, honda.Mpg);
            WriteLine("After overloaded operator, the {0} gets {1} miles per gallon.\n", ford.Model, ford.Mpg);
        }
    }

    class Car
    {
        private string model;
        private double mpg;

        public string Model { get; set; }
        public double Mpg { get; set; }

        public Car(string model, double mpg)
        {
            Model = model;
            Mpg = mpg;
        }

        public Car (string model)
        {
            Model = model;
            Mpg = 20;
        }

        public static Car operator++ (Car car)
        {
            double newMpg = car.Mpg + 1;
            string model = car.Model;
            return (new Car(model, newMpg));

        }
    }
}
