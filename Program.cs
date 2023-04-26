using System;
namespace workshopweek4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] market = new char[n];
            for (int i = 0; i < n; i++)
            {
                market[i] = '-';
            }

            while (true)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                if (a != 0 || b != 0 || a > 0 || b > 0)
                {
                    market[a - 1] = 'X';
                    market[b - 1] = 'X';
                }
                else if (a < 1)
                {
                    market[b - 1] = 'X';
                }
                else if (b < 1)
                {
                    market[a - 1] = 'X';
                }
                else if (a == b)
                {
                    market[a - 1] = 'X';
                }
                else if (a < 1 && b < 1)
                {
                    break;
                }
                break;
            }

            for (int k = 0; k < n; k++)
            {
                Console.Write(market[k]);
            }

        }

    }
}


