using System;

namespace basic13
{
    class Program
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i < 256; i++)
            {
                System.Console.WriteLine(i);
            }
        }
        public static void PrintOdd()
        {
            for (int i = 0; i < 255; i++)
            {
                if (i % 2 == 1)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i < 255; i++)
            {
                sum += i;
                System.Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }
        public static void LoopArray(int[] numbers)
        {
            foreach (int num in numbers)
            {
                System.Console.WriteLine(num);
            }
        }
        public static void FindMax(int[] numbers)
        {
            int max = 0;
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            System.Console.WriteLine(max);
        }
        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
                System.Console.WriteLine($"new sum: {sum}");
            }
            int average = sum / numbers.Length;
            System.Console.WriteLine(average);
        }
        public static int[] OddArray()
        {
            int[] NewArr = new int[127];
            int count = 0;
            for (int i = 0; i < 255; i++)
            {
                if (i % 2 == 1)
                {
                    NewArr[count] = i;
                    count++;
                }
            }
            return NewArr;
        }
        public static int GraterThanY(int[] numbers, int y)
        {
            int Count = 0;
            foreach (int num in numbers)
            {
                if (num > y)
                {
                    Count++;
                }
            }
            return Count;
        }
        public static void SquareArrayValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
        }
        public static void EliminateNegatives(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
        }
        public static void MinMaxAverage(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
                if (num > max)
                {
                    max = num;
                }
                else if (num < min)
                {
                    min = num;
                }
            }
            int average = total / numbers.Length;
            System.Console.WriteLine($"average: {average} Max: {max} Min: {min}");
        }
        public static void shiftValues(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i - 1] = numbers[i];
                if (i == numbers.Length - 1)
                {
                    numbers[i] = 0;
                }
            }
            foreach (int num in numbers)
            {
                System.Console.WriteLine(num);
            }
        }
        public static object[] NumToString(int[] numbers)
        {
            object[] NewArr = new object[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    NewArr[i] = "Dojo";
                }
                else
                {
                    NewArr[i] = numbers[i];
                }
            }
            foreach (object item in NewArr)
            {
                System.Console.WriteLine(item);
            }
            return NewArr;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, -1, 5, 6, -7, 7, 8, 9, 10 };
            NumToString(array);
        }
    }
}
