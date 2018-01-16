## Rotate Encryption

- Simple encryption using array rotation.

### Support characters

```
0123456789
abcdefghijklmnopqrstuvwxyz
ABCDEFGHIJKLMNOPQRSTUVWXYZ
```

### Installation

```
nuget install DotNetEncryption
```

### Usage

```csharp
using RotateEncryption;

var input = "SecretToken1234";
var encrypt = Rotate.Encrypt(input);
var decrypt = Rotate.Decrypt(encrypt);
Console.WriteLine(input == decrypt);
```