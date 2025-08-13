

namespace DemoConsole.Part3_Variables
{
    public class ScopeDemo
    {
        static int globalVariable = 10; // biến toàn cục trong class
        public static void Run()
        {
            Console.WriteLine("\n=== 3.3 Scope Demo ===");
            Console.WriteLine($"Global value: {globalVariable}");

            int outer = 10; // biến cục bộ
            {
                int inner = 20; // biến cục bộ trong khối lệnh
                Console.WriteLine($"Outer: {outer}, Inner: {inner}");
            }

            //Console.WriteLine(inner); // Lỗi: inner không thể truy cập ở đây vì nó chỉ tồn tại trong khối lệnh trên
        }
    }
}
