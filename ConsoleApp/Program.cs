namespace ConsoleApp
{
    using System;
    using Library;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The answer is {Thing.Get(19, 23)}");
        }
    }
}
