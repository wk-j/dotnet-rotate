using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetRotate
{
    public class AREncryption
    {
        static char[] setOfCharacters = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".Reverse().ToArray();
        static char[] setOfRotatedCharacters = new char[0];

        static AREncryption()
        {
            setOfRotatedCharacters = Rotate(setOfCharacters);
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

        public static string Encrypt(string values)
        {
            var indexs = values.ToArray().Select(x => Array.IndexOf(setOfCharacters, x));
            var rotatedChars = indexs.Select(x => setOfRotatedCharacters.ElementAt(x)).ToArray();
            var result = new String(rotatedChars);
            return result;
        }

        public static string Decrypt(string values)
        {
            var indexs = values.ToArray().Select(x => Array.IndexOf(setOfRotatedCharacters, x));
            var rotatedChars = indexs.Select(x => setOfCharacters.ElementAt(x)).ToArray();
            var result = new String(rotatedChars);
            return result;
        }

    }
}