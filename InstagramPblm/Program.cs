using System;

namespace InstagramPblm
{
    class Program
    {
        static void Main(string[] args)
        {
			int count = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < count; i++)
			{
				string[] n = Console.ReadLine().Split(' ');
				int follower = Convert.ToInt32(n[0]);
				int following = Convert.ToInt32(n[1]);
				if (follower>following*10)
				{
					Console.WriteLine("Yes");
				}
                else
                {
					Console.WriteLine("No");
				}
			}

			Console.ReadKey();
		}
    }
}
