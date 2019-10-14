using System;

namespace Open_Lab_02._5
{
    class Program
    {
        public static bool DivisibleByFive(int num)
        {
            return (num % 5 == 0);
        }
        static void Main(string[] args)
        {
            bool divisiblebyfive;
            int num;

            Console.WriteLine("Zadaj si číslo:");
            num = int.Parse(Console.ReadLine());

            divisiblebyfive = DivisibleByFive(num);
            Console.WriteLine(divisiblebyfive);


        }


    }
}
