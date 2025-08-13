using DemoConsole.Part1_Structure;
using DemoConsole.Part2_Data_Types;
using DemoConsole.Part3_Variables;
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

        // Phần 3: Biến
        Variables variables = new Variables();
        variables.Run();

        // Phần 4: Toán tử
        OperatorsDemo operatorsDemo = new OperatorsDemo();
        operatorsDemo.Run();

        // Phần 5: Câu lệnh điều khiển
        ControlStatementsDemo controlStatementsDemo = new ControlStatementsDemo();
        controlStatementsDemo.Run();

        // Phần 6: Mảng và Collections
        ArraysCollectionsDemo arraysCollectionsDemo = new ArraysCollectionsDemo();
        arraysCollectionsDemo.Run();

        // Phần 7: String
        StringDemo stringDemo = new StringDemo();
        stringDemo.Run();

        // Phần 8: Methods
        Methods methods = new Methods();
        methods.Run();

        // Phần 9: Date Times
        DateTimesDemo dateTimesDemo = new DateTimesDemo();
        dateTimesDemo.Run();

        Console.WriteLine("Chương trình kết thúc.");
    }
}