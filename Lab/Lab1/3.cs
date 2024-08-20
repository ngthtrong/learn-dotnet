namespace learn_dotnet.Lab.Lab1
{
    public class StringPractice
    {
        string data = "Worm snakes are usually reptiles with a body length of up to 23 cm. The snout is relatively narrow, accounting for about 20 - 33% of the width of the head.The eyes of this widely distributed snake are visible.The snake's color is almost uniform, the upper body is dark brown to black but the lower body is lighter.The snout, anal area, and tip of the tail are pale.";
        public void PrintWords()
        {
            string[] words = data.Split(' ');
            Console.WriteLine(string.Join(", ", words));
        }
    }





}