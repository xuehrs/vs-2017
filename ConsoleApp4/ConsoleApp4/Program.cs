using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            //var name = "<name>";
            //Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");
            ////不能运行，报错：错误 CS1056  意外的字符“$”
            ////Console.WriteLine($ "Hello, {name}. It's a pleasure to meet you!");





            //在屏幕显示提示
            Console.Write("按任意键自动消失bash窗口...");
            //表示不管按什么键都会消失
            Console.ReadKey(true);
        }
    }
}
