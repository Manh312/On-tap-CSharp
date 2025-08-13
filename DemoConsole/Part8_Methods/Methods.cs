
public class Methods
{
    public void Run()
    {
        Console.WriteLine("\n=== 8. Methods ===");
        // void vs kiểu trả về
        PrintMessage();
        int sum = Add(5, 3, 10); 
        Console.WriteLine($"Tổng: {sum}");

        // 2. Tham số: ref
        int a = 10;
        ModifyRef(ref a);
        Console.WriteLine($"ref: {a}");

        // 3. Tham số: out
        int b;
        GetValue(out b);
        Console.WriteLine($"out: {b}"); 

        // 4. Tham số: params
        int total = SumNumbers(1, 2, 3, 4, 5);
        Console.WriteLine($"params: {total}"); 

        // 5. Tham số: in
        int c = 100;
        MultiplyIn(in c, 2);
        Console.WriteLine($"in: {c}"); 

        // 6. Overloading (nạp chồng)
        Console.WriteLine($"Overload int: {Add(2, 3, 10)}"); 
        Console.WriteLine($"Overload double: {Add(2.5, 3.5)}"); 

        // 7. Default parameters
        Greet("Mạnh");
        Greet("Minh", "Rất vui"); 

        // 8. Expression-bodied methods
        string greeting = GetGreeting("Quang");
        Console.WriteLine(greeting); // Hello, Charlie!
    }

    // 1. void (không trả về)
    static void PrintMessage()
    {
        Console.WriteLine("Đây là void method!");
    }

    // Kiểu trả về
    static int Add(int x, int y)
    {
        return x + y;
    }

    // 2. ref (tham chiếu, thay đổi giá trị gốc)
    static void ModifyRef(ref int value)
    {
        value *= 2;
    }

    // 3. out (phải gán giá trị trong method)
    static void GetValue(out int value)
    {
        value = 15;
    }

    // 4. params (số lượng tham số biến đổi)
    static int SumNumbers(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    // 5. in (chỉ đọc, không thay đổi giá trị gốc)
    static void MultiplyIn(in int value, int multiplier)
    {
        Console.WriteLine($"in tính toán: {value * multiplier}");
    }

    // 6. Overloading (nạp chồng)
    static int Add(int x, int y, int z)
    {
        return x + y + z;
    }
    static double Add(double x, double y)
    {
        return x + y;
    }

    // 7. Default parameters
    static void Greet(string name, string message = "Hello")
    {
        Console.WriteLine($"{message}, {name}!");
    }

    // 8. Expression-bodied methods
    static string GetGreeting(string name) => $"Hello, {name}!";
}