using System;

namespace HungryNinja
{
    class Food
    {
        //=============== Attributes up top ================//
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        string GetName
        {
            get
            {
                return Name;
            }
        }
        //================= Constructor(s) =================//
        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
        //==================== Methods =====================//
    }
}