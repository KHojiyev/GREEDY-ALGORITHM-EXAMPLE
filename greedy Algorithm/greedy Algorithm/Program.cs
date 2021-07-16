using System;

namespace greedy_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            void greedyAlgorithmmm(int n)
            {

                int[] coins = new int[4]{ 20, 10, 5, 1 };
                int d = 0;

                while (n> 0)
                {
                    if (coins[d] > n)
                    {
                        d++;
                    }
                    else
                    {
                        Console.Write(coins[d]+"\t");
                        n = n - coins[d];
                    }
                }
                Console.WriteLine("\n");
            }



            int i;
            for (i = 1; i <= 20; i++)
            {
                greedyAlgorithmmm(i);
            }
            

        }

      
       
    }
}
