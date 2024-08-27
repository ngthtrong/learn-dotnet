using System.Dynamic;

namespace learn_dotnet.Lab.Lab1
{
    interface IShape
    {
        double Area();
    }
    public class MyCircle : IShape
    {
        public double Radius { get; set; }
        public MyCircle(double radius)
        {
            Radius = radius;
        }
        public double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public double Area()
        {
            return Length * Width;
        }
    }
    public class Square : IShape
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }
        public double Area()
        {
            return Side * Side;
        }
    }
}