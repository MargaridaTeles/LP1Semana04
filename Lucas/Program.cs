using System;

namespace Lucas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Lucas(7));
        }

        private static int Lucas(int n)
        {
            if(n == 0)
            {
                return 2;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return (Lucas(n - 2) + Lucas(n - 1));
            }
        }
    }
}
