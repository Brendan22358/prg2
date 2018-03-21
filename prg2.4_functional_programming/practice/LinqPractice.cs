using System;
using System.Collections.Generic;
using System.Linq;

public class LinqPractice
{
    public void problem1()
    {
        Console.WriteLine("Write Something");
        string str = Console.ReadLine();
        List<string> str1ng = new List<string>();
        List<string> STR1NG = new List<string>();
        str1ng = str.Split(' ').ToList();
        STR1NG = str.ToUpper().Split(' ').ToList();
        List<string> STR1ng = str1ng.Intersect(STR1NG).ToList();
        Console.WriteLine(" ", STR1ng.ToArray());
    }

}