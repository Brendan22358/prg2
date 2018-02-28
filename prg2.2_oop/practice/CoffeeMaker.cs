using System;
using System.Collections.Generic;
namespace prg2._2_oop
{
    public class CoffeeMaker : ConsumableMaker
    {
        public CoffeeMaker()
        {
        Ingredients = new Dictionary<System.Type, Consumable>();
        MaxIngredients = new Dictionary<System.Type, double>();
        Ingredients[typeof(Water)]= new Water();
        Ingredients[typeof(Coffee)]= new Coffee();
        Ingredients[typeof(Grain)]= new Grain();
        Ingredients[typeof(PaperFilter)]= new PaperFilter();

        MaxIngredients[typeof(Water)] = 12.0;
        MaxIngredients[typeof(Grain)] = 1.0;
        MaxIngredients[typeof(Coffee)] = 12.0;
        MaxIngredients[typeof(PaperFilter)] = 2.0;
        }
        public void AddWater(double AmountOfWater)
        {
            if(Ingredients[typeof(Water)].Quantity + AmountOfWater > MaxIngredients[typeof(Water)])
            {
                throw new Exception ("Too Much Water");
            }
            else
            {
                Ingredients[typeof(Water)].Quantity += AmountOfWater;
            }
        }
        public void AddGrains(double AmountOfGrains)
        {
            Ingredients[typeof(Grain)].Quantity += AmountOfGrains;
        }
        public void InsertFilter()
        {
            Ingredients[typeof(PaperFilter)].Quantity += 1;
        }
        public override Consumable Make()
        {
            throw new NotImplementedException();
        }

    }
}