using System;
using System.Collections.Generic;


namespace Puzzles
{
    class Program
    {
        static int[] RandomArray()
        {
            int[] RanArr = new int[10];
            Random Rand = new Random();
            int max = 0;
            int min = 0;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                RanArr[i] = Rand.Next(5, 25);
                if (i == 0)
                {
                    min = RanArr[i];
                }
                if (RanArr[i] > max)
                {
                    max = RanArr[i];
                }
                else if (RanArr[i] < min)
                {
                    min = RanArr[i];
                }
                sum += RanArr[i];
            }
            System.Console.WriteLine($"min: {min} max: {max} sum: {sum}");
            return RanArr;
        }
        static string TossCoin()
        {
            Random Rand = new Random();
            int number = Rand.Next(100) % 2;
            string side = "unknown";
            if (number == 0)
            {
                side = "Heads";
            }
            else
            {
                side = "Tails";
            }
            return side;
        }
        static string TossMultipleCoins(int num)
        {
            int heads = 0;
            for (int i = 0; i < num; i++)
            {
                if (TossCoin() == "Heads")
                {
                    heads++;
                }
            }
            string ratio = $"{heads}:{num}";
            return ratio;
        }
        static List<string> Names()
        {
            List<string> Names = new List<string> { "Todd", "Tiffany", "Charlie", "Sydney" };
            List<int> ListNumbers = new List<int>();
            List<string> NewNames = new List<string>();
            Random rand = new Random();
            int randNum;
            foreach (string name in Names)
            {
                do
                {
                    randNum = rand.Next(0, Names.Count);
                } while (ListNumbers.Contains(randNum));
                ListNumbers.Add(randNum);

                string CurrentName = Names[randNum];
                System.Console.WriteLine(CurrentName);

                if (CurrentName.Length > 5)
                {
                    NewNames.Add(CurrentName);
                }
            }
            return NewNames;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(Names());
        }
    }
}
