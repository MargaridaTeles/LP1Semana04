using System;

namespace Power2Method
{
    class Program
    {
        static void Main(string[] args)
        {
            PowersOf2Until5();

            PowerOf2UntilN(7);
            PowerOf2UntilN(10);
        }
        private static void PowersOf2Until5()
        {
            PowerOf2UntilN(5);
        }
        private static void PowerOf2UntilN(int n)
        {
            for(int i = 1; i <= (1 << n); i <<= 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
