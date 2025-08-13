public class ArraysCollectionsDemo { 
    public void Run ()
    {
        Console.WriteLine("\n=== 6. ArraysCollections ===");
        // Mảng 1 chiều
        Console.WriteLine("=== 6.1 Mảng 1 chiều ===");
        int[] array = new int[5];
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;
        foreach (int num in array)
        {
            Console.WriteLine($"{num}");
        }

        // Mảng đa chiều
        Console.WriteLine("\n=== 6.2 Mảng đa chiều ===");
        int[,] matrix = new int[2, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };
        Console.WriteLine("Mảng đa chiều:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"{matrix[i, j]}");
            }
        }

        // Mảng jagged (mảng của mảng)
        Console.WriteLine($"\n=== 6.3 Mảng jagged ===");
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2 };
        jaggedArray[1] = new int[] { 3, 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };
        Console.WriteLine("Mảng jagged:");
        foreach (int[] jagged in jaggedArray)
        {
            foreach (int num in jagged)
            {
                Console.WriteLine($"{num}");
            }    
        };

        // List<T>
        Console.WriteLine($"\n=== 6.4 List<T> ===");
        List<int> list = new List<int> { 10, 20, 30 };
        list.Add(40);
        Console.WriteLine($"List<T>: ");
        foreach (int num in list)
        {
            Console.WriteLine($"{num}");
        }

        // Dictionary<TKey, TValue>
        Console.WriteLine($"\n=== 6.5 Dictionary<TKey, TValue> ===");
        Dictionary<string, int> dict = new Dictionary<string, int>
        {
            { "One", 1 },
            { "Two", 2 }
        };
        dict["Three"] = 3;
        Console.WriteLine("Dictionary<TKey, TValue>: ");
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        };

        // HashSet<T>
        Console.WriteLine($"\n=== 6.6 HashSet<T> ===");
        HashSet<int> hashSet = new HashSet<int> { 1, 2, 3 };
        hashSet.Add(4);
        Console.WriteLine("HashSet<T>: ");
        foreach (int num in hashSet)
        {
            Console.WriteLine($"{num}");
        }

        // Queue<T>
        Console.WriteLine($"\n=== 6.7 Queue<T> ===");
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        Console.WriteLine("Queue<T> (FIFO):");
        foreach (int num in queue)
        {
            Console.Write($"{num} ");
        }

        // Stack<T>
        Console.WriteLine($"\n\n=== 6.8 Stack<T> ===");
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        Console.WriteLine("Stack<T> (LIFO):");
        foreach (int num in stack)
        {
            Console.Write($"{num} ");
        }
    }
}
