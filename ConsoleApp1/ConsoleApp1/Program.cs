using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            String aFriend = "Bill";
            Console.WriteLine(aFriend);



            String aFriend1 = "Maira";
            Console.WriteLine(aFriend1);
            Console.WriteLine("Hello" + aFriend1);
            //这个无效
            Console.WriteLine($"Hello aFriend");
            Console.WriteLine($"Hello {aFriend}");



            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
            //length获得字符串的长度
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
            Console.WriteLine($"Hello123 {firstFriend}");



            //删除字符串的空格相关
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");
            
            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");



            //替换字符串
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);
            //全部转大写或小写
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());



            //判断字符窜位置是否符合预期
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("and"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));
            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));


            //命令窗口不要太快消失
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
