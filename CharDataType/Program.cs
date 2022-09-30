using System;
namespace DataTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'B';
            Console.WriteLine($"Char: " + (char)ch);
            Console.WriteLine($"Equivalent Number: {(byte)ch}");
            Console.WriteLine($"Char Minimum: {(int)char.MinValue} and Maximum: {(int)char.MaxValue}");
            Console.WriteLine($"Char Size: {sizeof(char)} Byte");
            Console.ReadKey();
        }
    }
}
