using System;

namespace CSharpLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 5;
            int count = 0;
            Console.WriteLine("Введите пятизначное число:");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            int i = number;
            foreach (char c in i.ToString())
            {
                count = count + 1;
            }

            if (count > 5)
            {
                Console.Write("Многовато");
            }
            if (count < 5)
            {
                Console.Write("Маловато");
            }
            if (count == 5)
            {
                foreach (char c in i.ToString())
                {
                    Console.Write(c + "\n");
                }
            }
        }
    }
}