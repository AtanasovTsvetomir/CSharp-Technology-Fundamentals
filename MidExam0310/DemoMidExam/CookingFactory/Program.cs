using System;
using System.Linq;
using System.Collections.Generic;
namespace CookingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int maxSum = 0;
            double maxAvg = 0;
            int counter = 0;

            int[] bestBatch = new int[command.Length];

            while (command != "Bake It!")
            {
                int[] batchesOfBread = command.Split('#')
                    .Select(int.Parse)
                    .ToArray();

                int sumOfBatches = batchesOfBread.Sum();
                double averageOfBatches = batchesOfBread.Average();
                double bestBatchAvg = bestBatch.Average();

                counter++;

                if (counter == 1)
                {
                    bestBatch = batchesOfBread;
                    maxSum = bestBatch.Sum();
                }
                else
                {
                    if (sumOfBatches > maxSum)
                    {
                        maxSum = sumOfBatches;
                        bestBatch = batchesOfBread;
                    }

                    if (sumOfBatches == maxSum)
                    {
                        if (bestBatchAvg < averageOfBatches)
                        {
                            bestBatchAvg = averageOfBatches;
                            bestBatch = batchesOfBread;
                        }
                    }
                    if (bestBatchAvg == averageOfBatches && sumOfBatches == maxSum)
                    {
                        if (batchesOfBread.Length < bestBatch.Length)
                        {
                            bestBatch = batchesOfBread;
                        }
                    }
                }

                

                command = Console.ReadLine();
            }
            Console.WriteLine($"Best Batch quality: {maxSum}");
            Console.WriteLine(string.Join(" ", bestBatch));
        }
    }
}
