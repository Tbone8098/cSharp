using System;

namespace WNS
{
    class Samurai : Human
    {
        //=============== Attributes up top ================//
        //================= Constructor(s) =================//
        public Samurai(string name) : base(name)
        {
            Name = name;
            Health = 200;
        }

        //==================== Methods =====================//
        public void AttackOverride(Human target, int dmg)
        {
            // call base Attack back
            Attack(target);
            // if attackers health is 50 points or less set their points to 0
            if (target.Health > 50)
            {
                target.Health = 0;
            }
        }
        public void Meditate()
        {
            Health = 200;
        }
    }
}