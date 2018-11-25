using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            foreach (var aaa in names)
            {
                Console.WriteLine($"Hello {aaa.ToString()}");
            }
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }





            //在屏幕显示提示
            Console.Write("按任意键自动消失bash窗口...");
            //表示不管按什么键都会消失
            Console.ReadKey(true);
        }
    }
}
