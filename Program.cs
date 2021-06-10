using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main()
        {
            List<int> unsortedNumbers = new List<int> {33333, -23, 100, 1, 2, 8, 7, 6, 5, 4, 3, 2, 1};
            Console.Write("Beginning: ");
            foreach(int x in unsortedNumbers){
                Console.Write(x + " ");
            }
            Console.WriteLine("\n----------------");
            List<int> sortedNumbers = BubbleSort(unsortedNumbers);
            Console.Write("Final: ");
            foreach(int x in sortedNumbers){
                Console.Write(x + " ");
            }
        }

        static List<int> BubbleSort(List<int> numbers)
        {
            int end = numbers.Count;
            for(int i = 0; i < numbers.Count; i++){
                for (int j = 0; j < end - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
                end--;
            }
            return numbers;
        }
    }
}
