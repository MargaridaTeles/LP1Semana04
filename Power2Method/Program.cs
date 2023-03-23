using System;

namespace Power2Method
{
    class Program
    {
        /// <summary>
        /// Mostrar até à 5ª potência de 2
        /// </summary>
        /// <param name="args"> Argumentos recebidos na consola</param>
        static void Main(string[] args)
        {
            PowersOf2Until5();

            PowerOf2UntilN(7);
            PowerOf2UntilN(10);
        }
        /// <summary>
        ///  Mostrar até à 5ª potência de 2
        /// </summary>
        private static void PowersOf2Until5()
        {
            PowerOf2UntilN(5);
        }
        /// <summary>
        ///  Mostra até à N potência de 2
        /// </summary>
        /// <param name="n"> Número inteiro que define o limite da potência de 2</param>
        private static void PowerOf2UntilN(int n)
        {
            for(int i = 1; i <= (1 << n); i <<= 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
