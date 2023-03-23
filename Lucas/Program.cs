using System;

namespace Lucas
{
    class Program
    {
        /// <summary>
        /// Mostra a sequencia de Lucas com index n
        /// </summary>
        /// <param name="args"> Limite index</param>
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            Console.WriteLine(Lucas(n));
        }
        /// <summary>
        /// Mostra a sequencia de Lucas com index em n
        /// </summary>
        /// <param name="n"> Limite do index</param>
        /// <returns> Retorna o número indexado em n </returns>
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
