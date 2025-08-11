namespace DemoConsole.Part2_DataTypes
{
    public class EnumDemo
    {
        enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

        public static void Run()
        {
            Day today = Day.Monday;
            Console.WriteLine("=== 2.5 Enum ===");
            Console.WriteLine($"Today is: {today}");
            Console.WriteLine($"Day index: {(int)today}");
            Console.WriteLine();
        }
    }
}
