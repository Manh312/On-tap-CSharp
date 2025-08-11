namespace DemoConsole.Part2_DataTypes
{
    public class VarDynamicObjectDemo
    {
        public static void Run()
        {
            var number = 10; // kiểu int
            dynamic anything = "Hello"; // có thể đổi kiểu lúc runtime
            object obj = 42; // chứa mọi loại dữ liệu

            Console.WriteLine("=== 2.4 Var, dynamic, object ===");
            Console.WriteLine($"var number: {number} (type: {number.GetType()})");
            Console.WriteLine($"dynamic anything: {anything} (type: {anything.GetType()})");
            Console.WriteLine($"object obj: {obj} (type: {obj.GetType()})");
            Console.WriteLine();
        }
    }
}
