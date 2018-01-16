using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetRotate
{
    class Program
    {
        static char[] characters = "1234567890abcdefghijklmnopqrstuvwzyzABCDEFGHIJKLMNOPQRSTUVWZYZ".Reverse().ToArray();
        static char[] rotated = new char[0];

        static Program()
        {
            rotated = Rotate(characters);
        }

        private static char[] Rotate(char[] data, int length = 100)
        {
            IEnumerable<T> cycle<T>(IEnumerable<T> input)
            {
                while (true)
                {
                    foreach (var x in input) yield return x;
                }
            }

            IEnumerable<T> rotate<T>(IEnumerable<T> input, int n) =>
                cycle(input).Skip(input.Count() + n).Take(input.Count());

            return rotate(data, length).ToArray();
        }

        private static string Encrypt(string values)
        {
            var indexs = values.ToArray().Select(x => Array.IndexOf(characters, x));
            var rotatedChars = indexs.Select(x => rotated.ElementAt(x)).ToArray();
            var result = new String(rotatedChars);
            return result;
        }

        private static string Decrypt(string values)
        {
            var indexs = values.ToArray().Select(x => Array.IndexOf(rotated, x));
            var rotatedChars = indexs.Select(x => characters.ElementAt(x)).ToArray();
            var result = new String(rotatedChars);
            return result;
        }

        static void Main(string[] args)
        {
            var input = "3073sjiwabciwhgs";
            var a = Encrypt(input);
            var b = Decrypt(a);

            Console.WriteLine(input);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}