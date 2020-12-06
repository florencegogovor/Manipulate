using System;

namespace Manipulate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "manipulate";
            Console.Write("Please enter a text");
            string text = Console.ReadLine();
            Console.Write("\nThanks. You Entered:\n " + text);
            Console.WriteLine("\t\t Text Length: " + text.Length);
            text = text.Trim();
            Console.Write("\nTrimmed:\t" + text +);
        }
    }
}
