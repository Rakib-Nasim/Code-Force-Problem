using System;

namespace Rain_in_Chefland
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                int y = Convert.ToInt32(Console.ReadLine());
                if (y < 3)
                {
                    Console.WriteLine("LIGHT");
                }
                else if(y>=3 && y < 7)
                {
                    Console.WriteLine("MODERATE");
                }
                else
                {
                    Console.WriteLine("HEAVY");
                }
            }
        }
    }
}
