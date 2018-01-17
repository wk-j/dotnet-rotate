using System;
using Xunit;

namespace RotateEncryption.Tests {
    public class RotateTest {
        [Fact]
        public void ShouldEncryptText() {
            var input = "SecretToken1234";
            var encrypt = RotateEncryption.Rotate.Encrypt(input);
            var decrypt = RotateEncryption.Rotate.Decrypt(encrypt);
            Console.WriteLine("{0} {1} {2}", input, encrypt, decrypt);
            Assert.Equal(input, decrypt);
        }
    }
}
