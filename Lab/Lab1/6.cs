using System;
namespace learn_dotnet.Lab.Lab1
{

    public class CountCharInString
    {
        string data;
        public void ReadString()
        {
            data = Console.ReadLine();
        }
        public void CountChar(char x)
        {
            char[] arrChar = data.Where(myChar => myChar == x).ToArray();
            Console.WriteLine(arrChar.Length);
        }
    }




}