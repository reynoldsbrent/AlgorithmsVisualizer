namespace AlgorithmsVisualizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Algorithms Visualizer! Please select an algorithm to visualize. Enter a number 1-9: ");
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Selection Sort");
            Console.WriteLine("3. Insertion Sort");
            Console.WriteLine("4. Merge Sort");
            Console.WriteLine("5. Quick Sort");
            Console.WriteLine("6. Heap Sort");
            Console.WriteLine("7. Radix Sort");
            Console.WriteLine("8. Counting Sort");
            Console.WriteLine("9. Bucket Sort");
            Console.WriteLine("To quit, type 'exit'.");
            string algorithmSelection = Console.ReadLine();
            while (algorithmSelection != "exit")
            {
                Console.WriteLine("Please enter a list of numbers that you would like to have sorted: ");
                string numberList = Console.ReadLine();

                List<int> numbers = new List<int>();
                foreach (string number in numberList.Split(' '))
                {
                    numbers.Add(int.Parse(number));
                }

                switch (algorithmSelection)
                {
                    case "1":
                        Algorithms.BubbleSort(numbers);
                        numberList = Algorithms.ListToString(numbers);
                        Console.WriteLine("Sorted list: " + numberList);
                        break;
                    case "2":
                        Algorithms.SelectionSort(numbers);
                        numberList = Algorithms.ListToString(numbers);
                        Console.WriteLine("Sorted list: " + numberList);
                        break;
                    case "3":
                        Algorithms.InsertionSort(numbers);
                        numberList = Algorithms.ListToString(numbers);
                        Console.WriteLine("Sorted list: " + numberList);
                        break;
                    case "4":
                        int[] numArray = numbers.ToArray();
                        Algorithms.MergeSort(numArray);
                        numberList = Algorithms.ArrayToString(numArray);
                        Console.WriteLine("Sorted list: " + numberList);
                        break;
                    case "5":
                        Algorithms.QuickSort(numbers, 0, numbers.Count - 1);
                        numberList = Algorithms.ListToString(numbers);
                        Console.WriteLine("Sorted list: " + numberList);
                        break;
                    case "6":
                        Algorithms.HeapSort(numbers);
                        numberList = Algorithms.ListToString(numbers);
                        Console.WriteLine("Sorted list: " + numberList);
                        break;
                    case "7":
                        Algorithms.RadixSort(numbers);
                        numberList = Algorithms.ListToString(numbers);
                        Console.WriteLine("Sorted list: " + numberList);
                        break;
                    case "8":
                        Algorithms.CountingSort(numbers);
                        numberList = Algorithms.ListToString(numbers);
                        Console.WriteLine("Sorted list: " + numberList);
                        break;
                    case "9":
                        Algorithms.BucketSort(numbers);
                        numberList = Algorithms.ListToString(numbers);
                        Console.WriteLine("Sorted list: " + numberList);
                        break;
                }

                Console.WriteLine("1. Bubble Sort");
                Console.WriteLine("2. Selection Sort");
                Console.WriteLine("3. Insertion Sort");
                Console.WriteLine("4. Merge Sort");
                Console.WriteLine("5. Quick Sort");
                Console.WriteLine("6. Heap Sort");
                Console.WriteLine("7. Radix Sort");
                Console.WriteLine("8. Counting Sort");
                Console.WriteLine("9. Bucket Sort");
                Console.WriteLine("To quit, type 'exit'.");
                algorithmSelection = Console.ReadLine();
            }

        }
    }
}
