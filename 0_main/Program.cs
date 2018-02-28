using System;
using prg2._1_intro;
using prg2._2_oop;
using prg2._3_design_patterns;
using prg2._4_functional_programming;
using prg2._5_database_design;


namespace _0_main
{
    class Program
    {
          
        static void Main(string[] args)
        {   
            Console.WriteLine("Launching Main");
            NodeTest();
            Console.ReadKey();
        }
        static void NodeTest()
        {
            Console.WriteLine("I'm testing node");
            string done = "";

            while(done != "y")
            {
                Console.WriteLine("Are you done adding y/n?");
                done = Console.ReadLine().ToLower()
            }
        }
    }
}