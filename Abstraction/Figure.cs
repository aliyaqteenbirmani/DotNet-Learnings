using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public abstract class Figure
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;
        public abstract double GetArea();
    }

    public class Rectangle : Figure
    {
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    public class Circle : Figure
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double GetArea()
        {
            return (Radius * Radius) * Pi;
        }
    }

    public class Cone : Figure
    {
        public Cone(double radius, double height)
        {
            this.Radius = radius;
            this.Height = height;
        }

        public override double GetArea()
        {
            return Pi * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
    }

    class TestFigure
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(12.67, 56.78);
            Circle c = new Circle(45.67);
            Cone cn = new Cone(34.98, 12.98);

            Figure r1 = new Rectangle(12.67, 56.78);
            Figure c = new Circle(45.67);
            Figure cn = new Cone(34.98, 12.98);

            Console.WriteLine($"Area of Rectangle: {r1.GetArea()}");
            Console.WriteLine($"Area of Circle: {c.GetArea()}");
            Console.WriteLine($"Area of Cone: {cn.GetArea()}");

            Console.ReadLine();
        }
    }
}
