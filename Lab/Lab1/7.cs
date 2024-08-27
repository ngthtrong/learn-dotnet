namespace learn_dotnet.Lab.Lab1
{
    public class Circle
    {
        private double radius;

        // public void ReadRadius()
        // {
        //     radius = double.Parse(Console.ReadLine());
        // }
        public Circle()
        {
            this.radius = 0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public double Circumference()
        {
            return 2 * Math.PI * radius;
        }
        public virtual double Area()
        {
            return Math.PI * radius * radius;
        }

    }
    public class Sphere : Circle
    {
        public Sphere() : base() { }
        public Sphere(double radius) : base(radius) { }
        public override double Area()
        {
            return 4 * Math.PI * Radius * Radius;
        }
        public double Volume()
        {
            return 4 / 3 * Math.PI * Radius * Radius * Radius;
        }

    }
}