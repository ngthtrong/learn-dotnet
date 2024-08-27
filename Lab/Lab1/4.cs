using System;
namespace learn_dotnet.Lab.Lab1
{
    public class ListPractice
    {
        List<int> values = new List<int> { 1, 2, 3, 4, 5, 5, 6, 7, 10 };
        public void Sum()
        {
            Console.WriteLine(values.Where(x => x % 2 != 0).Sum());
        }
        public void PrintWordWithLength(List<string> words, int length)
        {
            List<string> wordList = words.Where(word => word.Length == length).ToList();
            Console.WriteLine("Words with length " + length + ": " + string.Join(", ", wordList));
        }
    }




}