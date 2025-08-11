namespace DemoConsole.Part1_Structure;

public class StructureDemo
{
    // Struct định nghĩa một kiểu dữ liệu giá trị
    public struct Person
    {
        public string Name;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old");
            Console.WriteLine();
        }
    }

    public void Run()
    {
        Console.WriteLine("=== 1. Structure Demo ===");
        Person person = new Person();
        person.Name = "Quang Mạnh";
        person.Age = 23;

        person.Introduce();
    }
}