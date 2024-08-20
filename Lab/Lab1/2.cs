
namespace learn_dotnet.Lab.Lab1
{
    public class ArrayPractice
    {
        private int[] base1 = new int[] { 1, 1, 2, 3, 5, 8, 13, 21 };
        public void PrintAll()
        {
            foreach (int i in base1)
            {
                Console.WriteLine(i);
            }
        }
        public void PrintOdd()
        {
            foreach (int i in base1)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

