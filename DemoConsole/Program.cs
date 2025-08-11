using DemoConsole.Part1_Structure;
using DemoConsole.Part2_Data_Types;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Chương trình bắt đầu...\n");

        // Phần 1: Cấu trúc dữ liệu
        StructureDemo structureDemo = new StructureDemo();
        structureDemo.Run();

        // Phần 2: Kiểu dữ liệu
        DataTypes dataTypes = new DataTypes();
        dataTypes.Run();

        Console.WriteLine("Chương trình kết thúc.");
    }
}