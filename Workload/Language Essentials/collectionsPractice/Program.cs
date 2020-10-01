using System;
using System.Collections.Generic;

namespace collectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] names = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            bool[] trueFalse = new bool[] { true, false, true, false, true, false, true, false, true, false };
            List<string> iceCreamFlavors = new List<string>();
            iceCreamFlavors.Add("chocolate");
            iceCreamFlavors.Add("vanilla");
            iceCreamFlavors.Add("peach");
            iceCreamFlavors.Add("marshmellow");
            iceCreamFlavors.Add("banana");
            System.Console.WriteLine($"there are {iceCreamFlavors.Count} Ice Cream flavors");
            iceCreamFlavors.RemoveAt(2);
            System.Console.WriteLine($"there are {iceCreamFlavors.Count} Ice Cream flavors");

            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            Random rand = new Random();
            for (int i = 0; i < names.Length; i++)
            {
                int index = rand.Next(iceCreamFlavors.Count);
                myDictionary.Add(names[i], iceCreamFlavors[index]);
            }
            foreach (KeyValuePair<string, string> entry in myDictionary)
            {
                System.Console.WriteLine(entry.Key + "-" + entry.Value);
            }
        }
    }
}
