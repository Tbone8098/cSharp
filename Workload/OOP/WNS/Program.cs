using System;

namespace WNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard John = new Wizard("John");
            Ninja Joe = new Ninja("Joe");
            Samurai Ted = new Samurai("Ted");

            John.Attack(Joe);
        }
    }
}
