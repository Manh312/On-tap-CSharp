public class ControlStatementsDemo
{
    public void Run ()
    {
        Console.WriteLine("\n=== 5. Control Statements ===");
        // Câu lệnh điều kiện if-else
        Console.WriteLine("=== 5.1 Câu lệnh điều kiện if-else ===");
        int number = 23;
        if (number > 0)
        {
            Console.WriteLine($"{number} là số dương");
        }
        else if (number == 0)
        {
            Console.WriteLine($"{number} bằng 0");
        }
        else
        {
            Console.WriteLine($"{number} là số âm");
        }

        // Câu lệnh switch-case
        Console.WriteLine("\n=== 5.2 Câu lệnh switch-case ===");
        object obj = 15;
        switch(obj)
        {
            case int i when i > 10:
                Console.WriteLine($"{obj} lớn hơn 10");
                break;
            case string s:
                Console.WriteLine($"Chuỗi: {s}");
                break;
            case null:
                Console.WriteLine($"Giá trị null");
                break;
            default:
                Console.WriteLine($"Giá trị không khớp");
                break;
        };

        // Vòng lặp for
        Console.WriteLine("\n=== 5.3 Vòng lặp for ===");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Vòng lặp for: {i}");
        }

        // Vòng lặp while
        Console.WriteLine("\n=== 5.4 Vòng lặp while ===");
        int count = 0;
        while (count < 2)
        {
            Console.WriteLine($"Vòng lặp while: {count}");
            count++;
        }

        // Vòng lặp do-while
        Console.WriteLine("\n=== 5.5 Vòng lặp do-while ===");
        int x = 0;
        do
        {
            Console.WriteLine($"Vòng lặp do-while: {x}");
            x++;
        }
        while (x < 1);

        // Vòng lặp foreach
        Console.WriteLine("\n=== 5.6 Vòng lặp foreach ===");
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int num in numbers)
        {
            Console.WriteLine($"Vòng lặp foreach: {num}");
        }

        // Câu lệnh break
        Console.WriteLine("\n=== 5.7 Câu lệnh break ===");
        for (int i = 0; i < 5; i++)
        {
            if (i == 2) break;
            Console.WriteLine($"Break tại: {i}");
        }

        // Câu lệnh continue
        Console.WriteLine("\n=== 5.8 Câu lệnh continue ===");
        for (int i = 0; i < 5; i++)
        {
            if (i == 2) continue; // Bỏ qua vòng lặp khi i = 2
            Console.WriteLine($"Continue tại: {i}");
        }

        // Câu lệnh return
        Console.WriteLine("\n=== 5.9 Câu lệnh return ===");
        int Sum(int a, int b)
        {
            return a + b; // Trả về tổng của hai số
        }
        Console.WriteLine($"Tổng hai số là: {Sum(2, 5)}");

    }
}