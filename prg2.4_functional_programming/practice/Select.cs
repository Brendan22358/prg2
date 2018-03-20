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
            List<string> changedWords = words.Select(word => word.ToLower() == "programming2" ? "Programming2 is Awesome" : word).ToList();
            List<string> approvedWords = changedWords.Where(word => !word.ToLower().Contains("cheeto")).ToList();

            List<string> cominedWords = words.Zip(changedWords,(word1,word2)=>word1+":"+word2).ToList();

            Console.WriteLine();
            foreach(string word in changedWords)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            foreach(string word in approvedWords)
            {
                Console.Write(word + " ");
            }

            DoSomething(Something);
            DoSomething(MakeUpperCase);

        }
        public string Something(string msg)
        {
            return "Help me Obi Won Kanobi!!!";
        }
        public void DoSomething(Func<string,string> anything)
        {
            Console.WriteLine(anything("please"));
            anything(anything("okay"));
        }
        public string MakeUpperCase(string msg)
        {
            return msg.ToUpper();
        }
    }
}