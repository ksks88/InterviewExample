using System;

namespace ConsoleAppTest
{
    public sealed class Circle
    {
        private double radius;
        const double PI = 3.14;
        public Circle(double r)
        {
            radius = r;
        }

        /// <summary>
        /// Calculates Circumference (2*r*3.14)
        /// </summary>
        public double Calculate(Func<double, double, double> op)
        {
            return op(radius, PI);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Console.WriteLine(circle.Calculate(calculateCircumference));
            Console.WriteLine(circle.Calculate((r, pi) => 2 * r * pi));
        }

        static double calculateCircumference(double r, double PI)
        {
            return 2 * r * PI;
        }
    }
}