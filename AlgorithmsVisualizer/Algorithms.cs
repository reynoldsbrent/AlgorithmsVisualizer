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
            int listLength = numbers.Count;

            for (int i = 0; i < listLength - 1; i++)
            {
                for (int j = 0; j < listLength - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
        }
        public static void InsertionSort(List<int> numbers)
        {
            int listLength = numbers.Count;

            for (int i = 1; i < listLength; i++)
            {
                int key = numbers[i];
                int flag = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (key < numbers[j])
                    {
                        numbers[j + 1] = numbers[j];
                    }
                    else
                    {
                        numbers[j + 1] = key;
                        flag = 1;
                        break;
                    }
                }   
            }   
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
