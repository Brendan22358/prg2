using System;

namespace prg2._2_oop
{
    public class MrCoffee : CoffeeMaker
    {
        DateTime CoffeeScheduled;
        DateTime CurrentTime;
        public void ScheduleCoffee(DateTime time)
        {
            CoffeeScheduled = time;
        }
        public void MakeCoffee()
            {
                if(DateTime.Now == CoffeeScheduled)
                {
                    MakeCoffee();
                }
            }
    }
}