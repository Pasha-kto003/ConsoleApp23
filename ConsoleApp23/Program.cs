using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (i % 2 == 0)
                {
                    char[] array = words[i].ToCharArray();
                    Array.Reverse(array);
                    words[i] = string.Join("", array);
                }
            }
            string alltext = string.Join(' ', words);
            Console.WriteLine(alltext);
        }
    }
}
