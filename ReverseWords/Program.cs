using System;
using System.Data;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string:");
            string phrase = Console.ReadLine();
            Anagram a = new Anagram();
            Console.WriteLine(a.ReversePhrase(phrase));
        }
    }
}