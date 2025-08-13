public class StringDemo
{
    public void Run()
    {
        Console.WriteLine("\n=== 7. String ===");
        // Nội suy chuỗi
        Console.WriteLine("=== 7.1 Nội suy chuỗi ===");
        string name = "Quang Mạnh";
        Console.WriteLine($"Hello {name}!");

        // 2. Ghép chuỗi
        Console.WriteLine("\n=== 7.2 Ghép chuỗi ===");
        string str1 = "I am";
        string str2 = "Quang Mạnh";
        string str3 = "23 years old";
        Console.WriteLine(str1 + " " + str2); 

        string concatResult = String.Concat(str1, " ", str3);
        Console.WriteLine(concatResult); 

        string[] words = { "Tôi", "là", "Mạnh" };
        string joinResult = String.Join(" ", words);
        Console.WriteLine(joinResult); 

        // 3. Các phương thức thường dùng
        Console.WriteLine("\n=== 7.3 Các thương thức ===");
        string text = "Xin chào, tôi là Quang Mạnh!";

        // Length
        Console.WriteLine($"Độ dài: {text.Length}"); 

        // Substring
        Console.WriteLine($"Cắt chuỗi: {text.Substring(0, 5)}"); 

        // Replace
        Console.WriteLine($"Thay thế: {text.Replace("Mạnh", "Minh")}"); 

        // Split
        string[] parts = text.Split(',');
        Console.WriteLine("Tách chuỗi:");
        foreach (string part in parts)
        {
            Console.WriteLine(part.Trim()); 
        }

        // Contains
        Console.WriteLine($"Chứa 'Mạnh': {text.Contains("Mạnh")}");

        // StartsWith
        Console.WriteLine($"Bắt đầu bằng 'Hello': {text.StartsWith("Xin")}");

        // EndsWith
        Console.WriteLine($"Kết thúc bằng '!': {text.EndsWith("!")}");
    }
}