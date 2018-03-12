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
            Node<double> n0 = new Node<double>(0.0);
            n0.next = new Node<double>(5.0,n0.root);
            n0++;
            n0.next = new Node<double>(15.0,n0.root);
            n0++;
            n0.Print(); 
            n0 = n0.root;
            Swapper<double>.swap(n0,n0.next);
            n0.Print();  
            n0 = n0.root;

        }
    }
}