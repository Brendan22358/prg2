﻿using System;
using System.Collections.Generic;
//For Lists you need this line


namespace prg2._1_intro
{
    public class Intro
    {
        public Intro(string[] args)
        {
            Console.WriteLine("Launched intro");

            List<string> students = new List<string>();

            students.Add("Slosar");
            students.Add("Engel");
            students.Add("Yoon");
            students.Add("Gallagher");

            foreach(string student in students)
            {
                Console.Write(student + " ");
            }
           
            Console.WriteLine();

            while(students.Count != 10)
            {
                students.Add("empty spot");
            }

            for(int x = 0; x < 10; x++)
            {
                Console.WriteLine(x);
            }

            Dictionary<string,int> studentGrades = new Dictionary<string,int>();
            studentGrades["Yoon"] = 110;
            studentGrades["Gallagher"] = 190;
            studentGrades["Engel"] = 1000;
            studentGrades["Slosar"] = 50;



            /*
            
            string answer= Console.ReadLine();
            
            Console.WriteLine("Enter a number");
            
            int x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter another number!");
            
            int y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("The sum of your two numbers is:");
            
            int z = x + y;
            
            Console.WriteLine(z);
            
            double v = 5.0;
            
            Console.WriteLine(v);
            
            bool xIsEqualtoY = x == y;
            
            if(x % 2 == 0)
            
            {
            
                Console.WriteLine("Divisible by 2");
            
            }   
            
            else if(x % 3 == 0)
            
            {
            
                Console.WriteLine("Divisible by 3");
            
            }
            
            else
            
            {
            
                Console.WriteLine("Is not divisible");
            
            }

            */

        } 
    }
}
