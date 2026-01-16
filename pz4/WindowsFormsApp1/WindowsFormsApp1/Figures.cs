using System;

namespace Lab4_Shapes
{
    
    public abstract class Shape
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

       
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public virtual string GetInfo()
        {
            return $"{Name}: S={CalculateArea():F2}, P={CalculatePerimeter():F2}";
        }
    }

    
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) : base("Коло")
        {
            Radius = radius;
        }

        public override double CalculateArea() => Math.PI * Radius * Radius;
        public override double CalculatePerimeter() => 2 * Math.PI * Radius;

        public override string GetInfo()
        {
            return base.GetInfo() + $", R={Radius}";
        }
    }

    
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) : base("Прямокутник")
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea() => Width * Height;
        public override double CalculatePerimeter() => 2 * (Width + Height);

        public override string GetInfo()
        {
            return base.GetInfo() + $", {Width}x{Height}";
        }
    }

   
    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side) : base("Квадрат")
        {
            Side = side;
        }

        public override double CalculateArea() => Side * Side;
        public override double CalculatePerimeter() => 4 * Side;

        public override string GetInfo()
        {
            return base.GetInfo() + $", Сторона={Side}";
        }
    }
}