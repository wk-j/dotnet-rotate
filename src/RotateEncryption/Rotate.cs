using System;
using System.Collections.Generic;
using System.Linq;

namespace RotateEncryption {
    static internal class Extensions {
        public static string ToStrings(this IEnumerable<char> values) =>
            new String(values.ToArray());
    }

    public class Rotate {
        static char[] characters = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".Reverse().ToArray();
        static char[] rotatedCharacters = RotateChars(characters);

        private static char[] RotateChars(char[] data, int length = 100) {
            IEnumerable<T> cycle<T>(IEnumerable<T> input) {
                while (true) {
                    foreach (var x in input) yield return x;
                }
            }

            IEnumerable<T> rotate<T>(IEnumerable<T> input, int n) =>
                cycle(input).Skip(input.Count() + n).Take(input.Count());

            return rotate(data, length).ToArray();
        }

        public static string Encrypt(string values) =>
            values.AsEnumerable().Select(x => Array.IndexOf(characters, x))
                .Select(x => rotatedCharacters.ElementAt(x)).ToStrings();

        public static string Decrypt(string values) =>
            values.AsEnumerable().Select(x => Array.IndexOf(rotatedCharacters, x))
                .Select(x => characters.ElementAt(x)).ToStrings();
    }
}