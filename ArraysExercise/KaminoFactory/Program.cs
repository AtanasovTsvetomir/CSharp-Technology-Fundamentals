using System;
using System.Linq;
namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int longestSubSequence = -1;
            int longestIndex = -1;
            int longestSubSum = -1;
            int indexOfLongest = 0;
            int indexOfSequance = 1;
            int[] sequnce = new int[length];

            string input = Console.ReadLine();

            while (input != "Clone them!")
            {
                int[] currentSequance = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int subsequance = 0;
                int subIndex = -1;
                int subSum = 0;
                int count = 0;

                for (int i = 0; i < length; i++)
                {
                    if (currentSequance[i] == 1)
                    {
                        count++;
                        subSum++;
                        if (count > subsequance)
                        {
                            subsequance = count;
                            subIndex = i - count;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
                if (subsequance > longestSubSequence)
                {
                    longestSubSequence = subsequance;
                    longestIndex = subIndex;
                    longestSubSum = subSum;
                    sequnce = currentSequance;
                    indexOfLongest = indexOfSequance;
                }
                else if (subsequance == longestSubSequence && longestIndex > subIndex)
                {
                    longestIndex = subIndex;
                    longestSubSum = subSum;
                    sequnce = currentSequance;
                    indexOfLongest = indexOfSequance;
                }
                else if (subsequance == longestSubSequence && longestIndex > subIndex && longestSubSum < subSum)
                {
                    longestSubSum = subSum;
                    sequnce = currentSequance;
                    indexOfLongest = indexOfSequance;
                }
                indexOfSequance++;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {indexOfLongest} with sum: {longestSubSum}.");
            Console.WriteLine(string.Join(" ", sequnce));
        }
    }
}
