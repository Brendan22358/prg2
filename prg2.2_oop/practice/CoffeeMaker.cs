using System;
namespace prg2._2_oop
{
    public class CoffeeMaker
    {
        //This is a method, it is a constructor
        double water_amount;
        double MAX_WATER_AMOUNT;
        double coffee_amount;
        double MAX_COFFEE_AMOUNT;
        bool on_off;
        double grains_amount;
        double MAX_GRAINS_AMOUNT;
        //hotplate

        public CoffeeMaker()
        {
            water_amount = 0;
            MAX_WATER_AMOUNT = 12;
            coffee_amount = 0;
            MAX_COFFEE_AMOUNT = 12;
            grains_amount = 0;
            MAX_GRAINS_AMOUNT = 6;
            on_off = false;
        }
        

        public void AddGrains(double scoops_of_grains)
        {
            if(grains_amount + scoops_of_grains > MAX_GRAINS_AMOUNT)
            {
                throw new Exception("Put some of that back, thats too much!");
            }
            else
            {
                grains_amount = grains_amount + scoops_of_grains;
            }
        }
        
        public void InsertFilter()
        {

        }
        public void AddWater()
        {

        }
    }
}
