using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            int count = 0;
            string text = Console.ReadLine(); //вводимый текст
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //разьитие текста на слова
            for (int i = 1; i < words.Length - 1; i++)
            {
                count++;
                if (i % 2 == 1) //проверка на четность
                {
                    char[] array = words[i].ToCharArray(); //разбивка слова на буквы
                    Array.Reverse(array); // переворот массива
                    words[i] = string.Join("", array); //сборка массива
                }
            }
            if(count > 6)
            {
                Console.WriteLine($"Слишком много слов введено: {count}");
                Console.WriteLine($"Количество лишних слов: {count - 6}");
            }
            string alltext = string.Join(' ', words); // сборка полного текста
            Console.WriteLine(alltext);
        }
    }
}
