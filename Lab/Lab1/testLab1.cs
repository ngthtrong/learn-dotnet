using learn_dotnet.Lab.Lab1;

public class Test
{
    public void MainTest(string[] args)
    {
        // --------------------1--------------------//
        HelloWorld helloWorld = new HelloWorld();
        helloWorld.Print();
        // --------------------2--------------------//
        ArrayPractice arrayPractice = new ArrayPractice();
        arrayPractice.PrintAll();
        arrayPractice.PrintOdd();
        // --------------------3--------------------//
        StringPractice stringPractice = new StringPractice();
        stringPractice.PrintWords();
        // --------------------4--------------------//
        ListPractice listPractice = new ListPractice();
        listPractice.Sum();
        List<string> words = new List<string>();
        for (int i = 0; i < 5; i++)
        {
            string tempWord;
            tempWord = Console.ReadLine();
            words.Add(tempWord);
        }
        listPractice.PrintWordWithLength(words, 3);
        // --------------------5--------------------//
        DictionaryPractice dictionaryPractice = new DictionaryPractice();
        dictionaryPractice.ReadStudents();
        dictionaryPractice.PrintStudents();
        dictionaryPractice.ModifyStudents(123, "concac");
        dictionaryPractice.PrintStudents();
        // --------------------6--------------------//
        CountCharInString countCharInString = new CountCharInString();
        countCharInString.ReadString();
        countCharInString.CountChar('x');
        // --------------------7--------------------//
        Circle circle = new Circle();
        circle.Radius = double.Parse(Console.ReadLine());
        Console.WriteLine(circle.Circumference().ToString("F3") + " - " + circle.Area().ToString("F3"));
        Sphere sphere = new Sphere();
        sphere.Radius = double.Parse(Console.ReadLine());
        Console.WriteLine(sphere.Volume().ToString("F3") + " - " + sphere.Area().ToString("F3"));
        // --------------------8--------------------//
        IShape myCircle = new MyCircle(5);
        IShape rectangle = new Rectangle(4, 6);
        IShape square = new Square(3);
        List<IShape> shapes = new List<IShape>{
                myCircle, rectangle, square
            };
        foreach (IShape shape in shapes)
        {
            Console.WriteLine($"Area: {shape.Area()}");
        }



    }
}