using System;

namespace Bull_or_Bear
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases= Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                string[] cal =  Console.ReadLine().Split(" ");
                int first = Convert.ToInt32(cal[0]);
                int second = Convert.ToInt32(cal[1]);
                if (first == second)
                {
                    Console.WriteLine("NEUTRAL");
                }
                else if (first > second)
                {
                    Console.WriteLine("LOSS");
                }
                else
                {
                    Console.WriteLine("PROFIT");
                }

            }
            Console.ReadKey();
        }
    }
}
