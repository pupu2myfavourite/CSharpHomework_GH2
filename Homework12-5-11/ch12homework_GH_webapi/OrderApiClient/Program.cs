using System;
using OrderSystem;

namespace OrderApiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Terminal terminal = new Terminal();
            terminal.Run();
        }
    }
}
