using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        //=============== Attributes up top ================//
        public List<Food> Menu;
        //================= Constructor(s) =================//
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Bananas", 105,false,true),
                new Food("BBQ Sandwitch", 250, true, false),
                new Food("Smores", 300, false, true),
                new Food("Spicy Hot Dogs", 200, true, false),
                new Food("Jelly Beans", 50, false, true),
                new Food("Steak", 450, false, false),
                new Food("French Fries", 400, false, false)
            };
        }
        //==================== Methods =====================//
        public Food Serve()
        {
            Random rand = new Random();
            int randNum = rand.Next(0, Menu.Count);
            System.Console.WriteLine(Menu[randNum].Name);
            return Menu[randNum];
        }
    }
}