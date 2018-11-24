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
            Console.WriteLine($"Hello aFriend");
            Console.WriteLine($"Hello {aFriend}");



            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
            Console.WriteLine($"Hello123 {firstFriend}");



            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");
            
            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");



            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());



            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("and"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));
            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));



            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
