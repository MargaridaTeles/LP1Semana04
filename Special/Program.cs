using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(GetSpecial(num));
        }

        private static int GetSpecial(int n)
        {
            int special;

            if (n == 0)
                special = 0;
            else if (n == 1)
                special = 1;
            else
                special = GetSpecial(n - 1) + 2 * GetSpecial(n -2);

            return special;
        }
    }
}
