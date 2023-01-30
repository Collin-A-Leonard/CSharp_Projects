using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ShapesDemo
{
    class ShapesDemo
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(4, 5);
            Square square = new Square(4);
            Square square2 = new Square(5, 1);
            Triangle triangle = new Triangle(4, 6);
            rectangle.DisplayInfo();
            square.DisplayInfo();
            square2.DisplayInfo();
            triangle.DisplayInfo();
            rectangle.Height = 7;
            square.Width = 8;
            square2.Height = 2;
            triangle.Width = 3;
            WriteLine();
            WriteLine("After alterations: ");
            rectangle.DisplayInfo();
            square.DisplayInfo();
            square2.DisplayInfo();
            triangle.DisplayInfo();
        }
    }
    abstract class GeometricFigure
    {
        private readonly double area;
        public double Height { get; set; }
        public double Width { get; set; }
        public double Area { get; }
        abstract public double ComputeArea();

        public void DisplayInfo()
        {
            WriteLine("Type: " + GetType() + ", Height: " + Height + ", Width: " + Width + ", Area: " + ComputeArea());
        }

        public GeometricFigure(double width, double height)
        {
            Height = height;
            Width = width;
            area = ComputeArea();
        }
        
        public GeometricFigure(double value)
        {
            Height = value;
            Width = value;
            area = ComputeArea();
        }

    }
    class Rectangle : GeometricFigure
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }
         public override double ComputeArea()
        {
            return Width * Height;
        }
    }

    class Square : GeometricFigure
    {
        public Square(double value) : base(value)
        {

        }
        public Square(double width, double height) : base(getParameters(height, width))
        {
        }

        public override double ComputeArea()
        {
            return Width * Height;
        }

        private static double getParameters(double height, double width)
        {
            if (width != height)
            {
                if (width > height)
                    return width;
                else
                    return height;
            }
            else
                return height;
        }
    }
    class Triangle : GeometricFigure
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }

        public override double ComputeArea()
        {
            return Width * (Height / 2);
        }
    }
}
