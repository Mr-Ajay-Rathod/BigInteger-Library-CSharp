# Quick Start Guide - BigInt C# Library

## Installation

Copy the `BigInt.cs` file to your project or reference the compiled `BigIntegerLibrary.dll`.

## Basic Usage

### Creating Big Integers

```csharp
// From string
BigInt num1 = new BigInt("123456789123456789");

// From integer types
BigInt num2 = new BigInt(42);
BigInt num3 = new BigInt(1000000000L);

// Default (zero)
BigInt num4 = new BigInt();  // value: 0

// Copy
BigInt num5 = new BigInt(num1);
```

### Arithmetic Operations

```csharp
BigInt a = new BigInt("1000");
BigInt b = new BigInt("500");

// Basic operations
BigInt sum = a + b;           // 1500
BigInt diff = a - b;          // 500
BigInt product = a * b;       // 500000
BigInt quotient = a / b;      // 2
BigInt remainder = a % b;     // 0

// With regular integers
BigInt result1 = a + 10;      // 1010
BigInt result2 = 20 * b;      // 10000
```

### Comparisons

```csharp
BigInt x = new BigInt("100");
BigInt y = new BigInt("200");

if (x < y) Console.WriteLine("x is smaller");
if (x != y) Console.WriteLine("x is different from y");
if (x == new BigInt("100")) Console.WriteLine("Equal!");
```

### Mathematical Operations

```csharp
// Power
BigInt power = BigInt.Pow(new BigInt(2), new BigInt(10));  // 1024

// Square root
BigInt sqrt = BigInt.Sqrt(new BigInt(144));  // 12

// Absolute value
BigInt absVal = BigInt.Abs(new BigInt(-100));  // 100

// Logarithms
BigInt log2 = BigInt.Log2(new BigInt(8));      // 3
BigInt log10 = BigInt.Log10(new BigInt(1000));  // 3
```

### Number Theory

```csharp
BigInt a = new BigInt(48);
BigInt b = new BigInt(18);

// GCD and LCM
BigInt gcd = BigInt.GCD(a, b);     // 6
BigInt lcm = BigInt.LCM(a, b);     // 144

// Factorial
BigInt fact = BigInt.Factorial(new BigInt(5));  // 120

// Prime checking
if (BigInt.IsPrime(new BigInt(17))) {
    Console.WriteLine("17 is prime");
}

// Palindrome checking
if (BigInt.IsPalindrome(new BigInt("12321"))) {
    Console.WriteLine("12321 is a palindrome");
}
```

### Other Utilities

```csharp
// Reverse digits
BigInt rev = BigInt.Reverse(new BigInt("12345"));  // 54321

// Min/Max
BigInt x = new BigInt(100);
BigInt y = new BigInt(200);
BigInt maximum = BigInt.Max(x, y);  // 200
BigInt minimum = BigInt.Min(x, y);  // 100

// Swap
BigInt p = new BigInt(10);
BigInt q = new BigInt(20);
BigInt.Swap(ref p, ref q);  // p=20, q=10
```

### Conversion to String

```csharp
BigInt num = new BigInt("999999999999999999");
string str = num.ToString();
```

## Common Use Cases

### Computing Large Factorials
```csharp
BigInt result = new BigInt(1);
for (int i = 2; i <= 100; i++) {
    result *= new BigInt(i);
}
Console.WriteLine($"100! = {result}");
```

### Fibonacci Sequence
```csharp
BigInt a = new BigInt(0);
BigInt b = new BigInt(1);
for (int i = 0; i < 50; i++) {
    BigInt temp = a + b;
    a = b;
    b = temp;
}
Console.WriteLine($"50th Fibonacci: {b}");
```

### Cryptographic Operations
```csharp
// Working with large numbers for RSA, etc.
BigInt p = new BigInt("61");
BigInt q = new BigInt("53");
BigInt n = p * q;  // 3233
```

### Scientific Calculations
```csharp
// Computing powers of large bases
BigInt base10 = new BigInt(10);
BigInt power100 = BigInt.Pow(base10, new BigInt(100));  // 10^100
```

## Performance Tips

1. **Minimize conversions**: Create BigInt objects once and reuse them
2. **Use appropriate operations**: Division is slower than multiplication
3. **Cache results**: Avoid recalculating the same values
4. **Prime checking**: Very slow for large numbers (>100 digits)
5. **Square root**: Uses binary search, good performance

## Error Handling

```csharp
try {
    // Division by zero throws exception
    BigInt result = new BigInt(10) / new BigInt(0);
}
catch (DivideByZeroException ex) {
    Console.WriteLine("Cannot divide by zero");
}

try {
    // Invalid input throws exception
    BigInt num = new BigInt("not a number");
}
catch (ArgumentException ex) {
    Console.WriteLine("Invalid number format");
}
```

## Limitations

- Numbers must be integers (no decimals)
- Very large numbers (>100K digits) may be slow
- Prime checking is slow for numbers larger than 100+ digits
- Maximum size limited only by available memory

## API Reference

### Constructors
- `BigInt()` - Default (0)
- `BigInt(string s)` - From string
- `BigInt(long n)` - From long
- `BigInt(int n)` - From int
- `BigInt(BigInt n)` - Copy constructor

### Operators
- Arithmetic: `+`, `-`, `*`, `/`, `%`
- Comparison: `>`, `<`, `>=`, `<=`, `==`, `!=`
- Assignment: `+=`, `-=`, `*=`, `/=`, `%=`
- Increment/Decrement: `++`, `--`

### Static Methods
- `Pow(BigInt a, BigInt b)` - a^b
- `Sqrt(BigInt a)` - Square root
- `Abs(BigInt a)` - Absolute value
- `Log2(BigInt a)` - Log base 2
- `Log10(BigInt a)` - Log base 10
- `LogWithBase(BigInt a, BigInt b)` - Log with custom base
- `Antilog2(BigInt a)` - 2^a
- `Antilog10(BigInt a)` - 10^a
- `GCD(BigInt a, BigInt b)` - Greatest common divisor
- `LCM(BigInt a, BigInt b)` - Least common multiple
- `Factorial(BigInt a)` - Factorial
- `Max(BigInt a, BigInt b)` - Maximum
- `Min(BigInt a, BigInt b)` - Minimum
- `Reverse(BigInt a)` - Reverse digits
- `Swap(ref BigInt a, ref BigInt b)` - Swap two values
- `IsPrime(BigInt a)` - Check if prime
- `IsPalindrome(BigInt a)` - Check if palindrome

### Instance Methods
- `ToString()` - Convert to string

## Support

For issues or questions, refer to the full documentation in `README.md` or examine the test cases in `Program.cs`.
