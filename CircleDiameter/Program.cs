using System;
using System.Collections.Generic;
namespace CircleApp
{
    class Circle
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle() 
        {
            radius = 0.0;

        } 
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public double getRadius()
        {
            return radius;

        }
        public double getArea()
        {
            return Math.PI * radius * radius;

        }
        public double getDiameter()
        {
            return 2 * Math.PI * radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(10);
            Console.WriteLine("The radius of the circle: {0}", c.getRadius());
            Console.WriteLine("The diameter of the circle: {0}", c.getRadius());
            Console.WriteLine("The circunference of the circle: {0}", c.getRadius());
            Console.WriteLine("The area of the circle: {0}", c.getRadius());
            Console.ReadLine();
        }
    }

}