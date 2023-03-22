using System;
using System.IO;
using System.Linq;

namespace RoadTrafficData
{
    class Program
    {
        static void Main()
        {
            // Read files into arrays
            int[] road1Data = File.ReadAllLines("Road_1_256.txt")
                                  .Select(int.Parse)
                                  .ToArray();

            int[] road2Data = File.ReadAllLines("Road_2_256.txt")
                                  .Select(int.Parse)
                                  .ToArray();

            int[] road3Data = File.ReadAllLines("Road_3_256.txt")
                                  .Select(int.Parse)
                                  .ToArray();

            // Sort arrays in ascending order
            Array.Sort(road1Data);
            Array.Sort(road2Data);
            Array.Sort(road3Data);

            // Display every 10th value of the sorted arrays in ascending order
            Console.WriteLine("Road_1_256.txt - Sorted in ascending order:");
            for (int i = 0; i < road1Data.Length; i += 10)
            {
                Console.WriteLine(road1Data[i]);
            }

            Console.WriteLine("\nRoad_2_256.txt - Sorted in ascending order:");
            for (int i = 0; i < road2Data.Length; i += 10)
            {
                Console.WriteLine(road2Data[i]);
            }

            Console.WriteLine("\nRoad_3_256.txt - Sorted in ascending order:");
            for (int i = 0; i < road3Data.Length; i += 10)
            {
                Console.WriteLine(road3Data[i]);
            }

            // Sort arrays in descending order
            Array.Reverse(road1Data);
            Array.Reverse(road2Data);
            Array.Reverse(road3Data);

            // Display every 10th value of the sorted arrays in descending order
            Console.WriteLine("\nRoad_1_256.txt - Sorted in descending order:");
            for (int i = 0; i < road1Data.Length; i += 10)
            {
                Console.WriteLine(road1Data[i]);
            }

            Console.WriteLine("\nRoad_2_256.txt - Sorted in descending order:");
            for (int i = 0; i < road2Data.Length; i += 10)
            {
                Console.WriteLine(road2Data[i]);
            }

            Console.WriteLine("\nRoad_3_256.txt - Sorted in descending order:");
            for (int i = 0; i < road3Data.Length; i += 10)
            {
                Console.WriteLine(road3Data[i]);
            }

            Console.ReadLine();
        }
    }
}