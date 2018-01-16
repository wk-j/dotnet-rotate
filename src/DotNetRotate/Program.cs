using System;

namespace DotNetRotate
{
    class Program
    {

        static void Main(string[] args)
        {
            var input = "3073sjiwabciwhgs";
            var a = AREncryption.Encrypt(input);
            var b = AREncryption.Decrypt(a);

            Console.WriteLine($"Input - {input}");
            Console.WriteLine($"Encrypt - {a}");
            Console.WriteLine($"Decrypt - {b}");
            Console.WriteLine($"Decrypt == Input - {input == b}");
        }
    }
}