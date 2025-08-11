

namespace DemoConsole.Part2_Data_Types
{
    internal class ReferenceTypesDemo
    {
        public static void Run()
        {
            string name = "Mạnh";
            object obj = 123; // object là kiểu dữ liệu tham chiếu, có thể chứa bất kỳ kiểu dữ liệu nào
            Person person = new Person
            {
                Name = "Quang Mạnh"
            };

            Console.WriteLine("=== 2.2 Reference Types ===");
            Console.WriteLine($"String: {name}");
            Console.WriteLine($"Object: {obj}");
            Console.WriteLine($"Person name: {person.Name}");
            Console.WriteLine();
        }

        public class Person
        {
            public string Name { get; set; }
        }
    }
}
