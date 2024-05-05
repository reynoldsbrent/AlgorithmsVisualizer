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
            string algorithmSelection = Console.ReadLine();
            Console.WriteLine("Please enter a list of numbers that you would like to have sorted: ");
            string numberList = Console.ReadLine();

            List<int> numbers = new List<int>();
            foreach (string number in numberList.Split(' '))
            {
                numbers.Add(int.Parse(number));
            }

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

        }
    }
}
