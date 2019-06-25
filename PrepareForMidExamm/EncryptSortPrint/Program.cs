using System;
using System.Linq;

namespace EncryptSortPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            string[] array = new string[numberOfStrings];
            
            for (int i = 0; i < numberOfStrings; i++)
            {
                array[i] = Console.ReadLine();
            }

            int[] encrypted = new int[numberOfStrings];

            for (int i = 0; i < numberOfStrings; i++)
            {
                encrypted[i] = EncryptTheString(array[i]);
            }

            foreach (var enc  in encrypted.OrderBy(e => e))
            {
                Console.WriteLine(enc);
            }
        }

        static int EncryptTheString (string array)
        {
            int sum = 0;

            foreach (var symbol in array)
            {
                if (IsVowel(symbol))
                {
                    sum += (int)symbol * array.Length;
                }
                else
                {
                    sum += (int)symbol / array.Length;
                }
            }

            return sum;
        }

        static bool IsVowel(char symbol)
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
