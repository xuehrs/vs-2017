using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            //int a = 5;
            //int b = 6;
            //if (a + b > 10)
            //    Console.WriteLine("The answer is greater than 10.");


            //int a = 5;
            //int b = 3;
            //if (a + b > 10)
            //    Console.WriteLine("The answer is greater than 10.");



            //int a = 5;
            //int b = 3;
            //if (a + b > 10)
            //    Console.WriteLine("The answer is greater than 10");
            //else
            //    Console.WriteLine("The answer is not greater than 10");



            //int a = 5;
            //int b = 3;
            //if (a + b > 10)
            //{
            //    Console.WriteLine("The answer is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine("The answer is not greater than 10");
            //}


            //&&  且
            //||  或


            //int a = 5;
            //int b = 3;
            //int c = 4;
            //if ((a + b + c > 10) && (a > b))
            ////&& 表示“且”。 也就是说，两个条件必须都为 true，才能执行 true 分支中的语句
            //{
            //    Console.WriteLine("The answer is greater than 10");
            //    Console.WriteLine("And the first number is greater than the second");
            //}
            //else
            //{
            //    Console.WriteLine("The answer is not greater than 10");
            //    Console.WriteLine("Or the first number is not greater than the second");
            //}


            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) || (a > b))
                //||表示”或“。只需要其中豫剧为真就可以了
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not greater than the second");
            }





















            Console.Write("按任意键自动消失bash窗口");
            //表示，不管按什么键都会消失；
            Console.ReadKey(true);
        }
    }
}
