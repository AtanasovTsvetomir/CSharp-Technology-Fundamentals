using System;
using System.Linq;
namespace EncryptAndSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            string[] strArray = new string[numberOfCommands];

            for (int i = 0; i < numberOfCommands; i++)
            {
                strArray[i] = Console.ReadLine();
            }

            int[] encrypted = new int[numberOfCommands];

            for (int i = 0; i < numberOfCommands; i++)
            {
                encrypted[i] = EncryptTheString(strArray[i]);
            }
            foreach (var enc in encrypted.OrderBy(e => e))
            {
                Console.WriteLine(enc);
            }
        }
        
        static int EncryptTheString(string str)
        {
            int sum = 0;

            foreach (var symbol in str)
            {
                if (isVowel(symbol))
                {
                    sum += (int)symbol * str.Length;
                }
                else
                {
                    sum += (int)symbol / str.Length;
                }
            }
            return sum;
        }
        static bool isVowel(char symbol)
        {
            char[] vowels = "aeiouAEIOU".ToCharArray();
            if (vowels.Contains(symbol)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
