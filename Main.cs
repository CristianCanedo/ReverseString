using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = Console.ReadLine();
            string reversed = String.Empty;
            int index;
            
            for (index = source.Length - 1; index >= 0; index--)
            {
                reversed += source[index];
            }
            
            Console.WriteLine(reversed);
        }
    }
}
