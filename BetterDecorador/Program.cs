using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string sentence = args[0];
            char c = char.Parse(args[1]);
            int num = int.Parse(args[2]);
            
            Console.WriteLine(Decor(sentence, c, num));
        }

        private static string Decor(string s, char dec, int num)
        {
            return $"{new string(dec, num)} {s} {new string(dec, num)}";
        }
    }
}
