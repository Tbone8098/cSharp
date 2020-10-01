using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Tyler = new Human("Tyler");
            Human Joe = new Human("Joe");

            Joe.Attack(Tyler);
            Tyler.Attack(Joe);
        }
    }
}
