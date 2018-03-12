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
            Node<double> n0 = new Node<double>(0.0);
            Node<double> n1 = new Node<double>(1.0);
            Node<int> linkedList = new Node<int>(0);
            n0++;
            n0.Print();
            if(n0 == n1)
            {
                Console.WriteLine("They are equal");
            }
            Node<int> root = linkedList;
            while(done != "y")
            {
                Console.WriteLine("Insert an integer for linked list");
                int value = Convert.ToInt32(Console.ReadLine());
                linkedList.next = new Node<int>(value,root);
                linkedList = linkedList.next;
                Console.WriteLine("Are you done adding y/n?");
                done = Console.ReadLine().ToLower();
            }
            linkedList.Print();
            linkedList.PrintAll();
        }
    }
}