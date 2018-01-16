## Rotate Encryption

- Simple encryption using array rotation.

## Support characters

```
0123456789
abcdefghijklmnopqrstuvwxyz
ABCDEFGHIJKLMNOPQRSTUVWXYZ
```

## Installation

```
nuget install DotNetEncryption
```

## Usage

```csharp
var input = "SecretToken1234";
var encrypt = RotateEncryption.Rotate.Encrypt(input);
var decrypt = RotateEncryption.Rotate.Decrypt(encrypt);
Assert.Equal(input, decrypt);
```