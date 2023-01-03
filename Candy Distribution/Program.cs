using System;

namespace Candy_Distribution
{
    class Program
    {
        static void Main(string[] args)
        {
			int count = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < count; i++)
			{
				string[] nl = Console.ReadLine().Split(' ');
				int n = Convert.ToInt32(nl[0]);
				int m = Convert.ToInt32(nl[1]);
                if (n %m ==0)
                {
					int val = n / m;
                    if (val % 2 == 0)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
		}
    }
}
