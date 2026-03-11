using System;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// Convert the inputs and show the method Decor
        /// </summary>
        /// <param name="args">Input from user</param>
        private static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                string sentence = args[0];
                char c = char.Parse(args[1]);
                int num = int.Parse(args[2]);
                
                Console.WriteLine(Decor(sentence, c, num));
            }
            else
                Console.WriteLine(Decor());
        }

        /// <summary>
        /// Method have responsibility to make the text with the right specifications
        /// </summary>
        /// <param name="s">the string</param>
        /// <param name="dec">the character</param>
        /// <param name="num">the number of repetitions</param>
        /// <returns>The text with the decoration</returns>
        private static string Decor(string s, char dec, int num)
        {
            return $"{new string(dec, num)} {s} {new string(dec, num)}";
        }

        /// <summary>
        /// Method with the same name but make the text when 
        /// the user don't pass the arguments for decoration
        /// </summary>
        /// <returns>The default text with decoration</returns>
        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }
    }
}
