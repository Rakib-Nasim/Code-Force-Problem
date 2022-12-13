using System;

namespace Chairs_Requirement
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                string[] cal = Console.ReadLine().Split(" ");
                int first = Convert.ToInt32(cal[0]);
                int second = Convert.ToInt32(cal[1]);
                if (first == second || first<second)
                {
                    Console.WriteLine(0);
                }
                else
                { 
                    Console.WriteLine(first - second);
                }

            }
            Console.ReadKey();
        }
    }
}
