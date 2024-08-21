using System;
namespace learn_dotnet.Lab.Lab1
{
    public class ListPractice
    {
        public List<int> values = new List<int> { 1, 2, 3, 4, 5, 5, 6, 7, 10 };
        public void PrintSum()
        {
            Console.WriteLine(values.Where(x => x % 2 != 0).Sum());
        }




    }





}