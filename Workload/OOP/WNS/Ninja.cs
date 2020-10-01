using System;

namespace WNS
{
    class Ninja : Human
    {
        //=============== Attributes up top ================//
        //================= Constructor(s) =================//
        public Ninja(string name) : base(name)
        {
            Name = name;
            Dexterity = 175;
        }

        //==================== Methods =====================//
        public void AttackOverride(Human target, int dmg)
        {
            // reduces the targets health by 5 * wizards intel
            int returnDmg = Dexterity * 5;
            // 20% chance of doing an additional 10 dmg
            Random rand = new Random();
            int chance = rand.Next(0, 100);
            if (chance > 20)
            {
                returnDmg += 10;
            }
            target.Health -= returnDmg;
        }
        public void Steal(Human target)
        {
            target.Health -= 5;
            Health += 5;
        }
    }
}