using System;

namespace ConsoleApp4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new System.Collections.Generic.Dictionary<string, int>()
            {
                ["hammer, ball pein"] = 18,
                ["hammer, cross pein"] = 5,
                ["screwdriver, Phillips #2"] = 14
            };

            Console.WriteLine($"Inventory on {DateTime.Now:d}");
            Console.WriteLine(" ");
            Console.WriteLine($"|{"Item",-25}|{"Quantity",10}|");
                foreach (var item in inventory)
                    Console.WriteLine($"|{item.Key,-25}|{item.Value,10}|");
            foreach (var item in inventory)
                Console.WriteLine($"|{item.Key}|{item.Value}|");
            foreach (var item in inventory)
                Console.WriteLine($"|{item.Key,-50}|{item.Value,20}|");
            foreach (var item in inventory)
                Console.WriteLine($"|{item.Key,-50}|{item.Key,-50}|");
            foreach (var item in inventory)
                Console.WriteLine($"|{item.Value,-50}|{item.Value,-50}|");


            Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");


            string name = "Mark";
            var date = DateTime.Now;

            // Composite formatting:
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
            // String interpolation:
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
            // Both calls produce the same output that is similar to:
            // Hello, Mark! Today is Wednesday, it's 19:40 now.
            //添加空格倒是有用
            Console.WriteLine($"Hello,       {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");





            //在屏幕显示提示
            Console.Write("按任意键自动消失bash窗口...");
            //表示不管按什么键都会消失
            Console.ReadKey(true);
        }
    }
}
