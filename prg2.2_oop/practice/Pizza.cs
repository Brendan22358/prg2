using System;
using System.Collections.Generic;

namespace prg2._2_oop
{
    public abstract class Pizza : ConsumableMaker
    {
        public Pizza()
        {
            Ingredients = new Dictionary<System.Type,Consumable>();
            MaxIngredients = new Dictionary<System.Type,double>();
            Ingredients[typeof(cheese)] = new cheese();
            Ingredients[typeof(dough)] = new dough();
            Ingredients[typeof(sauce)] = new sauce();
            Ingredients[typeof(toppings)] = new toppings();
            Ingredients[typeof(money)] = new money();
            MaxIngredients[typeof(cheese)] = 5;
            MaxIngredients[typeof(dough)] = 10;
            MaxIngredients[typeof(sauce)] = 5;
            MaxIngredients[typeof(toppings)] = 10;
            MaxIngredients[typeof(money)] = 100000000000000000;
        }
        public void Adddough(double AmountOfdough)
        {
            if(Ingredients[typeof(dough)].Quantity + AmountOfdough> MaxIngredients[typeof(dough)])
            {
                throw new Exception("Too much dough!");
            }
            else
            {
                Ingredients[typeof(dough)].Quantity += AmountOfdough;
            }
        }
        public void Addsauce(double AmountOfsauce)
        {
            if(Ingredients[typeof(sauce)].Quantity + AmountOfsauce> MaxIngredients[typeof(sauce)])
            {
                throw new Exception("Too much sauce!");
            }
            else
            {
                Ingredients[typeof(sauce)].Quantity += AmountOfsauce;
            }
        }
        public void Addcheese(double AmountOfcheese)
        {
            if(Ingredients[typeof(cheese)].Quantity + AmountOfcheese> MaxIngredients[typeof(cheese)])
            {
                throw new Exception("Too much cheese!");
            }
            else
            {
                Ingredients[typeof(cheese)].Quantity += AmountOfcheese;
            }
        }
        public void Addtoppings(double AmountOftoppings)
        {
            if(Ingredients[typeof(toppings)].Quantity + AmountOftoppings> MaxIngredients[typeof(toppings)])
            {
                throw new Exception("Too many toppings!");
            }
            else
            {
                Ingredients[typeof(toppings)].Quantity += AmountOftoppings;
            }
        }
        public void Addmoney(double AmountOfmoney)
        {
            if(Ingredients[typeof(money)].Quantity + AmountOfmoney> MaxIngredients[typeof(money)])
            {
                throw new Exception("Too much money!");
            }
            else
            {
                Ingredients[typeof(money)].Quantity += AmountOfmoney;
            }
        }

        public override Consumable Make()
        {
            Ingredients[typeof(dough)].Quantity = 0;
            Ingredients[typeof(sauce)].Quantity = 0;
            Ingredients[typeof(cheese)].Quantity = 0;
            Ingredients[typeof(toppings)].Quantity = 0;
            Ingredients[typeof(money)].Quantity -= 10;
            return Ingredients[typeof(Pizza)];
        }

    }
}