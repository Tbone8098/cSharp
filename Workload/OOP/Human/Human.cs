using System;
using System.Collections.Generic;

namespace Human
{
    class Human
    {
        //=============== Attributes up top ================//
        public string Name;

        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health;
        public List<int> AttacksTaken;

        int GetHealth
        {
            get
            {
                foreach (int attack in AttacksTaken)
                {
                    Health -= attack;
                }
                return Health;
            }
        }
        //================= Constructor(s) =================//
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
            AttacksTaken = new List<int>();
        }
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
            AttacksTaken = new List<int>();
        }

        //==================== Methods =====================//
        public int Attack(Human target)
        {
            int AttackPower = Strength * 5;
            target.AttacksTaken.Add(AttackPower);
            int health = target.GetHealth;
            System.Console.WriteLine($"{target.Name}'s health is at {health}");
            return health;
        }

        // public void ReveiveAttacks(int amount)
        // {

        // }
    }
}