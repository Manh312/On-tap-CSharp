

namespace DemoConsole.Part3_Variables
{
    public class ConstantsDemo
    {
        const double Pi = 3.14159; // Hằng số Pi, const giá trị cố định
        static readonly DateTime StartTime; // readonly: gán 1 lần tại runtime

        static ConstantsDemo()
        {
            StartTime = DateTime.Now; // Gán giá trị cho readonly trong constructor tĩnh
        }
        public static void Run()
        {
            Console.WriteLine("\n=== 3.2 Constants Demo ===");
            Console.WriteLine($"Giá trị của Pi: {Pi}");
            Console.WriteLine($"StartTime: {StartTime}");
        }
    }
}
