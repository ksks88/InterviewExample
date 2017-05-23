using System;

namespace ConsoleAppTest
{
    public sealed class Circle
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        /// <summary>
        /// Calculates Circumference (2*r*3.14)
        /// </summary>
        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Console.WriteLine(circle.Calculate(calculateCircumference));
            Console.WriteLine(circle.Calculate(r => 2 * r * 3.14));
        }

        static double calculateCircumference(double r)
        {
            return 2 * r * 3.14;
        }
    }
}