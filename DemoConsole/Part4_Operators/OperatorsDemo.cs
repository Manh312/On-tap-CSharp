
public class OperatorsDemo
{
    public void Run()
    {
        Console.WriteLine("\n=== 4. Operators Demo ===");
        int a = 10, b = 5;
        // Phép toán cơ bản
        Console.WriteLine($"=== 4.1 Phép toán cơ bản ===");
        Console.WriteLine($"Phép cộng: {a + b}");
        Console.WriteLine($"Phép trừ: {a - b}");
        Console.WriteLine($"Phép nhân: {a * b}");
        Console.WriteLine($"Phép chia: {a/b}");
        Console.WriteLine($"Phép chia lấy dư: {a % b}");

        // Phép toán so sánh
        Console.WriteLine($"\n=== 4.2 Phép toán so sánh ===");
        Console.WriteLine($"Bằng nhau: {a == b}");
        Console.WriteLine($"Khác nhau: {a != b}");
        Console.WriteLine($"Lớn hơn: {a > b}");
        Console.WriteLine($"Nhỏ hơn: {a < b}");
        Console.WriteLine($"Lớn hơn hoặc bằng: {a >= b}");
        Console.WriteLine($"Nhỏ hơn hoặc bằng: {a <= b}");

        // Phép toán logic
        Console.WriteLine($"\n=== 4.3 Phép toán logic ===");
        bool x = true, y = false;
        Console.WriteLine($"AND: {x && y}");
        Console.WriteLine($"OR: {x || y}");
        Console.WriteLine($"NOT: {!x}");

        // Phép gán
        Console.WriteLine($"\n=== 4.4 Phép gán ===");
        int c = 20;
        c += 5;
        Console.WriteLine($"Gán cộng: {c}");
        c -= 3;
        Console.WriteLine($"Gán trừ: {c}");
        c *= 10;
        Console.WriteLine($"Gán nhân: {c}");

        // Toán tử logic điều kiên (Null-coalescing: ??)
        Console.WriteLine($"\n=== 4.5 Toán tử logic điều kiện (Null-coalescing) ===");
        int? nullableInt = null;
        int defaultValue = 0;
        Console.WriteLine($"Kết quả trả về: {nullableInt ?? defaultValue}");

        // Toán tử Null-conditional(?.) và Null-coalescing assignment(??=)
        Console.WriteLine($"\n=== 4.6 Toán tử Null-conditional và Null-coalescing assignment ===");
        string str = null;
        Console.WriteLine($"Null-conditional: {(str?.Length ?? 0)}");
        str ??= "Giá trị mặc định";
        Console.WriteLine($"Null-coalescing assignment: {str}");

        // Toán tử điều kiện (?:)
        Console.WriteLine($"\n=== 4.7 Toán tử điều kiện (?:) ===");
        int max = (a > b) ? a : b;
        Console.WriteLine($"Toán tử điều kiện: {max}");

        // Toán tử is 
        Console.WriteLine($"\n=== 4.8 Toán tử is ===");
        object obj = 100;
        if (obj is int)
        {
            Console.WriteLine($"Toán tử is: {obj} là int");
        }

        // Toán tử as (chỉ sử dụng cho tham chiếu hoặc kiểu nullable)
        Console.WriteLine($"\n=== 4.9 Toán tử as ===");
        object obj2 = "Quang Mạnh";
        string str2 = obj2 as string;
        Console.WriteLine($"Toán tử as: {str2} là string");

    }
}