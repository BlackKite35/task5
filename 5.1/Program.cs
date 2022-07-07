using System;

namespace _5._1
{
    class Program
    {
        static string[] WordSplitter(string phrase)
        {
            string[] result = phrase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return result;
        }

        static void PrintResult(string[] result)
        {
            foreach (var word in result)
            {
                Console.WriteLine($"{word}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинное предложение (используя пробелы):");
            string phrase = Console.ReadLine();

            string[] words = WordSplitter(phrase);

            PrintResult(words);


            Console.ReadLine();
        }

    }
}
