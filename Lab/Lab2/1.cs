namespace learn_dotnet.Lab.Lab2
{
    public class Fraction
    {
        private int Numerator;
        private int Denominator;
        public Fraction()
        {
            this.Numerator = 0;
            this.Denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
        public override string ToString()
        {
            return Numerator.ToString() + "/" + Denominator.ToString();
        }



        public Fraction Sub(int n)
        {
            return new Fraction(Numerator - (n * Denominator), Denominator * n);
        }
        public Fraction Sub(Fraction other)
        {
            return new Fraction((Numerator * other.Denominator) - (other.Numerator * Denominator), Denominator * other.Denominator);
        }
    }
    public class TestFraction
    {
        public void RunTest()
        {
            Fraction fraction = new Fraction();
            Console.WriteLine(fraction.ToString());
            Fraction fraction2 = new Fraction(7, 2);
            Fraction fraction3 = new Fraction(5, 4);
            Console.WriteLine(fraction2.ToString());
            Fraction sub1 = fraction2.Sub(1);
            Console.WriteLine(sub1.ToString());
            Fraction sub2 = fraction2.Sub(fraction3);
            Console.WriteLine(sub2.ToString());

        }
    }
}