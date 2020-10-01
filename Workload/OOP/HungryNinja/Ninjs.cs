using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Ninja
    {
        //=============== Attributes up top ================//
        public int CalorieIntake;
        public List<Food> FoodHistory;
        public string Name;


        bool IsFull
        {
            get
            {
                if (CalorieIntake > 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        //================= Constructor(s) =================//
        public Ninja(string name)
        {
            Name = name;
            CalorieIntake = 0;

        }
        //==================== Methods =====================//
        public void Eat()
        {
            if (!IsFull)
            {
                System.Console.WriteLine($"still not full, you can eat some more");
                System.Console.WriteLine($"Your calorie count is at {CalorieIntake}");
                // get randomly selcted food obj
                Food NinjaFood = new Buffet().Serve();
                // add calories
                CalorieIntake += NinjaFood.Calories;
                // output food info
                // FoodHistory.Add(NinjaFood);  // not working
            }
            else
            {
                // output to the console that the ninja is full and cannot eat anymore
                System.Console.WriteLine("You are too full, you need to stop eating");
            }
        }
    }
}