namespace DemoConsole.Part2_DataTypes
{
    public class NullableTypesDemo
    {
        public static void Run()
        {
            int? nullableInt = null;
            double? nullableDouble = 5.5;

            Console.WriteLine("=== 2.3 Nullable Types ===");
            Console.WriteLine($"Nullable Int: {nullableInt}");
            Console.WriteLine($"Nullable Double: {nullableDouble}");
            Console.WriteLine();
        }
    }
}
