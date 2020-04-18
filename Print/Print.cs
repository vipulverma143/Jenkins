using System;

namespace Printing
{
    public class Print
    {
        public void PrintSomething(string value)
        {
            Console.WriteLine($"printed value is: {value}");
            Console.ReadKey();
        }
    }
}
