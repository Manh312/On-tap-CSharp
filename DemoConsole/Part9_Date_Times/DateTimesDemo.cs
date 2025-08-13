public class DateTimesDemo
{
    public void Run()
    {
        Console.WriteLine("\n=== 9. DateTimes ===");
        // 1. DateTime.Now và DateTime.UtcNow
        Console.WriteLine("=== 9.1 DateTime.Now và DateTime.UtcNow ===");
        DateTime now = DateTime.Now;     
        DateTime utcNow = DateTime.UtcNow;   
        Console.WriteLine($"Now: {now}");     
        Console.WriteLine($"UtcNow: {utcNow}"); 

        // 2. Format chuỗi ngày giờ
        Console.WriteLine("\n=== 9.2 Format chuỗi ngày giờ ===");
        string formattedDate = now.ToString("dd/MM/yyyy");
        Console.WriteLine($"Định dạng: {formattedDate}"); 

        // 3. Phép cộng/trừ thời gian
        Console.WriteLine("\n=== 9.3 Phép cộng/trừ thời gian ===");
        DateTime future = now.AddDays(5);    
        DateTime past = now.AddHours(-2);   
        Console.WriteLine($"Sau 5 ngày: {future}"); 
        Console.WriteLine($"Trước 2 giờ: {past}");

        // 4. TimeSpan để đo khoảng thời gian
        Console.WriteLine("\n=== 9.4 TimeSpan để đo khoảng thời gian ===");
        TimeSpan duration = future - now;     
        Console.WriteLine($"Khoảng thời gian: {duration.Days} ngày"); 
    }
}