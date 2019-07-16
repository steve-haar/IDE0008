using System;

namespace IDE0008
{
    public class Class1
    {
        public static void Test()
        {
            var date = DateTime.UtcNow;
            var color = Color.Red;
            var date2 = new DateTime(1);
            var color2 = (Color)1;

            Console.WriteLine($"{date}{date2}{color}{color2}");
        }
    }

    internal enum Color
    {
        Red,
        Green,
        Blue
    }
}
