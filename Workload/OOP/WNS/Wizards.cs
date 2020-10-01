using System;

namespace WNS
{
    class Wizard : Human
    {
        //=============== Attributes up top ================//
        //================= Constructor(s) =================//
        public Wizard(string name) : base(name)
        {
            Name = name;
            Intelligence = 25;
            Health = 50;
        }

        //==================== Methods =====================//
        public void AttackOverride(Human target, int dmg)
        {
            // reduces the targets health by 5 * wizards intel
            int returnDmg = Intelligence * 5;
            target.Health -= returnDmg;
            // heals wizard amount being damaged
            Health += dmg;
        }
        public void Heal(Human target)
        {
            int healthBoost = Intelligence * 10;
            target.Health = healthBoost;
        }
    }
}