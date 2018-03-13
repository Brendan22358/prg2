using System;
using System.Collections.Generic;
using System.Linq;

namespace prg2._4_functional_programming
{
    public class Select
    {
        public void run()
        {
            List<string> words = new List<string>();
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();
            words = sentence.Split(new char[]{' '}).ToList();
            
            foreach(string word in words)
            {
                Console.Write(word + " ");
            }
            List<string> changedWords = words.Select(word => word.ToLower() == "gallagher" ? "Gallagher is Awesome" : word).ToList();
            Console.WriteLine();
            foreach(string word in changedWords)
            {
                Console.Write(word + " ");
            }
        }
    }
}