using System;


namespace prg2._1_intro
{
        public class hw2
    {
        public void run()
        {
            Console.Write("Enter the year: ");
            string year = Console.ReadLine();
            int yer = (int)Convert.ChangeType(year,typeof(int));
            yer = yer + 1;
            for(int x = 0; x<20;)
            {   
                if(yer % 400 == 0)
                {
                    Console.WriteLine(yer + " is a leap year.");
                    yer = yer + 1;
                    x++;
                }
                else if(yer % 100 == 0)
                {
                    yer = yer + 1;
                }
                else if(yer % 4 == 0)
                {
                    Console.WriteLine(yer + " is a leap year.");
                    yer = yer + 1;
                    x++;
                }
                else
                {
                    yer = yer + 1;
                }
                
            }
        

            
            Console.WriteLine("Press any button to finish the program");
        }
    }

}

