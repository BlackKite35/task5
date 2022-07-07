using System;

namespace _5._2
{
    class Program
    {

        static string WordSplitter(string phrase)
        {
            string[] wordsSplit = phrase.Split(' ');
            string Text = ReversWords(wordsSplit);
            return Text;
        }
        static string ReversWords(string[] phrase)
        {
            Array.Reverse(phrase);
            string result = string.Join(" ", phrase);
            return result;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введите длинное предложение (используя пробелы):");
            string words = Console.ReadLine();
            words = WordSplitter(words);

            Console.WriteLine(words);

            Console.ReadLine();
        }
    }
}
