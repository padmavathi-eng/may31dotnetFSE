using System;

namespace FirstVsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            num1 = 100;
            num2 = 200;
            sum = num1 + num2;
            Console.WriteLine($"The sum value is {sum}");
            Console.WriteLine("The sum is ",+sum);
            Console.WriteLine("The sum is {0}",sum);
            Console.WriteLine("For Loop");
            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine(i);
                
            }
            Console.WriteLine("While Loop");
            int count = 0;
            while (count<=10)
            {
                Console.WriteLine(count);
                count = count + 1;
                
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
