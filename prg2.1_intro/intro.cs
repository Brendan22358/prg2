using System;

namespace prg2._1_intro
{
    public class Intro
    {
        public Intro(string[] args)
        {
            Console.WriteLine("Launched intro");
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

        } 
    }
}
