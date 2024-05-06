using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsVisualizer
{
    public class Algorithms
    {
        public static void SelectionSort(List<int> numbers)
        {
            int listLength = numbers.Count;
            for (int i = 0; i < listLength - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < listLength; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;
            }

        }
        public static void BubbleSort(List<int> numbers)
        {

        }
        public static void InsertionSort(List<int> numbers)
        {

        }
        public static void MergeSort(List<int> numbers)
        {

        }
        public static void QuickSort(List<int> numbers)
        {

        }
        public static void HeapSort(List<int> numbers)
        {

        }
        public static void RadixSort(List<int> numbers)
        {

        }
        public static void CountingSort(List<int> numbers)
        {

        }
        public static void BucketSort(List<int> numbers)
        {

        }
        public static string ListToString(List<int> numbers)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int number in numbers)
            {
                sb.Append(number + " ");
            }
            return sb.ToString();
        }
    }
}
