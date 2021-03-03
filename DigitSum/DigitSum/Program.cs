using System;
using System.Collections.Generic;

namespace DigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };

            Console.WriteLine(FindNumber(array, 1));
            Console.WriteLine("------------------------------------------------");
            FindAllNumbers(array, 3).ForEach(n => Console.WriteLine(n));
            Console.ReadKey();
        }

        public static int CalculateSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum = sum + number % 10;
                number = number / 10;
            }
            return sum;
        }

        public static int? FindNumber(int[] array, int sum)
        {
            int? resultNumber = null;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (CalculateSum(array[i]) == sum)
                {
                    resultNumber = array[i];
                    break;
                }
            }
            return resultNumber;
        }

        public static List<int> FindAllNumbers(int[] array, int sum)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < array.Length-1; i++)
            {
                if (CalculateSum(array[i]) == sum)
                {
                    res.Add(array[i]);
                }
            }
            return res;
        }
    }
}
