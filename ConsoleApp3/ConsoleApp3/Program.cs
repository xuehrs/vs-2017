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

            //这个比较好看
            //int a = 5;
            //int b = 3;
            //int c = 4;
            //if ((a + b + c > 10) || (a > b))
            //    //||表示”或“。只需要其中豫剧为真就可以了
            //{
            //    Console.WriteLine("The answer is greater than 10");
            //    Console.WriteLine("Or the first number is greater than the second");
            //}
            //else
            //{
            //    Console.WriteLine("The answer is not greater than 10");
            //    Console.WriteLine("And the first number is not greater than the second");
            //}


            //int counter = 0;
            //while (counter < 10)
            //    //从0到9
            //{
            //    Console.WriteLine($"Hello World! The counter is {counter}");
            //    counter++;
            //}


            //int counter = 0;
            //while (counter > 10)
            ////故意写错，什么事也没有发生
            //{
            //    Console.WriteLine($"hello world! the counter is {counter}");
            //    counter++;
            //}



            //以后要注意这种语句，它的循环语句有中断语句“；”，目前C#教程中只看到这个do-while有这个特征
            //int counter = 0;
            //do
            //{
            //    Console.WriteLine($"Hello World! The counter is {counter}");
            //    counter++;
            //} while (counter < 10);


            //for (int counter = 0; counter < 10; counter++)
            //{
            //    Console.WriteLine($"Hello World! The counter is {counter}");
            //}


            /*
            计算 1 到 20 中所有可被 3 整除的整数的总和。 下面提供了一些提示：
            % 运算符可用于获取除法运算的余数。
            if 语句中的条件可用于判断是否应将数字计入总和。
            for 循环有助于对 1 到 20 中的所有数字重复执行一系列步骤。
            亲自试一试吧。 然后，看看自己是怎么做到的。 提示：你应获取的答案为 63。
    */

            int s = 0;
            for (int i = 0; i <= 20; i++)
                {
                if (i %3== 0)
                {
                    s = s + i;
                    Console.WriteLine(s);
                }
                }
            Console.WriteLine("最终结果: "+s);


            //int sum = 0;
            //for (int number = 1; number < 21; number++)
            //{
            //    if (number % 3 == 0)
            //    {
            //        sum = sum + number;
            //    }
            //}
            //Console.WriteLine($"The sum is {sum}");











            Console.Write("按任意键自动消失bash窗口");
            //表示，不管按什么键都会消失；
            Console.ReadKey(true);
        }
    }
}
