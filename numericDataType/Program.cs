using System;
namespace NumericDemo
{
    class numericdemo
    {
        static void Main(string[] args)
        {
            short num1 = 123;         //Int16 num1 = 123;
            int num2 = 456;             //Int32 num2 = 456;
            long num3 = 789;         // Int64 num3 = 789;

            long num = num1 + num2 + num3;
            Console.WriteLine($"short Min Value:{short.MinValue} and Max Value:{short.MaxValue}");
            Console.WriteLine($"short Size:{sizeof(short)} Byte");
            Console.WriteLine($"int Min Value:{int.MinValue} and Max Value:{int.MaxValue}");
            Console.WriteLine($"int Size:{sizeof(int)} Byte");
            Console.WriteLine($"long Min Value:{long.MinValue} and Max Value:{long.MaxValue}");
            Console.WriteLine($"long Size:{sizeof(long)} Byte");
            Console.ReadKey();
        }
    }
}
