using System;
using System.Collections.Generic;
using System.Linq;

namespace RotateEncryption {
    public class Rotate {
        static char[] characters = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".Reverse().ToArray();
        static char[] rotatedCharacters = new char[0];

        static Rotate() {
            rotatedCharacters = RotateChars(characters);
        }

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

        public static string Encrypt(string values) {
            var indexs = values.ToArray().Select(x => Array.IndexOf(characters, x));
            var rotatedChars = indexs.Select(x => rotatedCharacters.ElementAt(x)).ToArray();
            var result = new String(rotatedChars);
            return result;
        }

        public static string Decrypt(string values) {
            var indexs = values.ToArray().Select(x => Array.IndexOf(rotatedCharacters, x));
            var rotatedChars = indexs.Select(x => characters.ElementAt(x)).ToArray();
            var result = new String(rotatedChars);
            return result;
        }
    }
}