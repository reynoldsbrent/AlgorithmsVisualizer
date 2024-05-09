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
        public static void MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
                return;

            int mid = arr.Length / 2;

            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];

            for (int i = 0; i < mid; i++)
                left[i] = arr[i];

            for (int i = mid; i < arr.Length; i++)
                right[i - mid] = arr[i];

            MergeSort(left);
            MergeSort(right);

            Merge(arr, left, right);
        }

        private static void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    arr[k++] = left[i++];
                else
                    arr[k++] = right[j++];
            }

            while (i < left.Length)
                arr[k++] = left[i++];

            while (j < right.Length)
                arr[k++] = right[j++];
        }
        public static void QuickSort(List<int> numbers, int leftIndex, int rightIndex)
        {
            int i = 0;
            int j = numbers.Count - 1;
            int pivot = numbers[leftIndex];

            while (i <= j)
            {
                while (numbers[i] < pivot)
                {
                    i++;
                }
                while (numbers[j] > pivot)
                {
                    j--;
                }

                if(i <= j)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
            {
                QuickSort(numbers, leftIndex, j);
            }
            if (i < rightIndex)
            {
                QuickSort(numbers, i, rightIndex);
            }
            
        }
        public static void HeapSort(List<int> numbers, int size)
        {
            if (size <= 1)
            {
                return;
            }

            for(int i = size / 2 - 1; i >= 0; i--)
            {
                Heapify(numbers, size, i);
            }

            for (int i = size - 1; i > 0; i--)
            {
                int temp = numbers[0];
                numbers[0] = numbers[i];
                numbers[i] = temp;

                Heapify(numbers, i, 0);
            }
        }
        public static void Heapify(List<int> numbers, int size, int index)
        {
            int largestIndex = index;
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;

            if (leftChild < size && numbers[leftChild] > numbers[largestIndex])
            {
                largestIndex = leftChild;
            }

            if (rightChild < size && numbers[rightChild] > numbers[largestIndex])
            {
                largestIndex = rightChild;
            }

            if (largestIndex != index)
            {
                int temp = numbers[index];
                numbers[index] = numbers[largestIndex];
                numbers[largestIndex] = temp;

                Heapify(numbers, size, largestIndex);
            }
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
        public static string ArrayToString(int[] array)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int number in array)
            {
                sb.Append(number + " ");
            }
            return sb.ToString();
        }
    }
}
