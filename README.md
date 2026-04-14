# BigInt Library in C# 

This project implements a BigInteger library in C# that supports arbitrary-precision arithmetic for integers of any size. It enables accurate and efficient computation beyond the limits of built-in numeric types, with support for operations such as addition, subtraction, multiplication, division, and modular arithmetic. The library is designed for performance, reliability, and ease of integration into .NET applications.

- `BigInt.cs` - Main BigInt class with all operations and utility functions
- `Program.cs` - Test suite demonstrating the library usage
- `BigIntegerLibrary.csproj` - Project file for .NET 6.0

## Features

### Supported Operations

#### Arithmetic Operations
- **Addition** (`+`, `+=`): Add two big integers
- **Subtraction** (`-`, `-=`): Subtract one big integer from another
- **Multiplication** (`*`, `*=`): Multiply two big integers
- **Division** (`/`, `/=`): Divide one big integer by another
- **Modulus** (`%`, `%=`): Get remainder after division

#### Comparison Operations
- **Greater than** (`>`)
- **Less than** (`<`)
- **Greater than or equal** (`>=`)
- **Less than or equal** (`<=`)
- **Equality** (`==`)
- **Inequality** (`!=`)

#### Increment/Decrement
- **Pre/Post Increment** (`++`)
- **Pre/Post Decrement** (`--`)

#### Utility Functions
- `Abs(BigInt)` - Absolute value
- `Pow(BigInt, BigInt)` - Power operation (a^b)
- `Sqrt(BigInt)` - Square root
- `Log2(BigInt)` - Logarithm base 2
- `Log10(BigInt)` - Logarithm base 10
- `LogWithBase(BigInt, BigInt)` - Logarithm with custom base
- `Antilog2(BigInt)` - 2^a
- `Antilog10(BigInt)` - 10^a
- `GCD(BigInt, BigInt)` - Greatest Common Divisor
- `LCM(BigInt, BigInt)` - Least Common Multiple
- `Factorial(BigInt)` - Factorial calculation
- `Reverse(BigInt)` - Reverse the digits
- `Max(BigInt, BigInt)` - Maximum of two values
- `Min(BigInt, BigInt)` - Minimum of two values
- `IsPalindrome(BigInt)` - Check if palindromic
- `IsPrime(BigInt)` - Check if prime number
- `Swap(ref BigInt, ref BigInt)` - Swap two BigInts

## Usage Examples

### Basic Arithmetic
```csharp
BigInt a = new BigInt("123456789");
BigInt b = new BigInt("987654321");

// Addition
BigInt sum = a + b;
Console.WriteLine($"Sum: {sum}");

// Subtraction
BigInt diff = a - b;
Console.WriteLine($"Difference: {diff}");

// Multiplication
BigInt product = a * b;
Console.WriteLine($"Product: {product}");

// Division
BigInt quotient = a / b;
Console.WriteLine($"Quotient: {quotient}");

// Modulus
BigInt remainder = a % b;
Console.WriteLine($"Remainder: {remainder}");
```

### Mixed Operations with Regular Integers
```csharp
BigInt big = new BigInt("1000000000");

// Operations with regular int and long
BigInt result1 = big + 5;
BigInt result2 = 10 * big;
BigInt result3 = big - 100;
```

### Comparison Operations
```csharp
BigInt a = new BigInt("100");
BigInt b = new BigInt("200");

if (a < b)
{
    Console.WriteLine("a is less than b");
}

if (a != b)
{
    Console.WriteLine("a is not equal to b");
}
```

### Power and Square Root
```csharp
BigInt base2 = new BigInt(2);
BigInt exp = new BigInt(100);
BigInt power = BigInt.Pow(base2, exp);
Console.WriteLine($"2^100 = {power}");

BigInt num = new BigInt("10000");
BigInt sqroot = BigInt.Sqrt(num);
Console.WriteLine($"Sqrt(10000) = {sqroot}");
```

### Number Theory Functions
```csharp
// GCD and LCM
BigInt x = new BigInt(48);
BigInt y = new BigInt(18);
Console.WriteLine($"GCD(48, 18) = {BigInt.GCD(x, y)}");
Console.WriteLine($"LCM(48, 18) = {BigInt.LCM(x, y)}");

// Factorial
BigInt n = new BigInt(10);
Console.WriteLine($"10! = {BigInt.Factorial(n)}");

// Prime checking
BigInt candidate = new BigInt(17);
if (BigInt.IsPrime(candidate))
{
    Console.WriteLine("17 is prime");
}

// Palindrome checking
BigInt palindrome = new BigInt("12321");
if (BigInt.IsPalindrome(palindrome))
{
    Console.WriteLine("12321 is a palindrome");
}
```

## Live Test Cases : 

<img width="1042" height="752" alt="image" src="https://github.com/user-attachments/assets/3d006594-b4b1-436e-a2f1-fa36d71b95a1" />
<img width="952" height="701" alt="image" src="https://github.com/user-attachments/assets/3092f43b-2a60-4035-a9f0-9d5087789cbd" />
<img width="1107" height="275" alt="image" src="https://github.com/user-attachments/assets/8aa20a8e-61aa-48bc-8526-3cbedd56fbed" />



## Building and Running

### Prerequisites
- .NET 6.0 SDK or later

### Build
```bash
dotnet build
```

### Run Tests
```bash
dotnet run
```

### Create as Library
To use this as a library in another project, you can build it as a class library:

```bash
dotnet build --configuration Release
```

Then reference the compiled assembly in your project.

## Migration Notes from C++

### Key Changes from C++ to C#

1. **Class Definition**: C++ `class bigint` → C# `public class BigInt`

2. **String Data Member**: Private `std::string str` → Private `string str` with similar functionality

3. **Constructors**: All constructors translated directly with similar initialization logic

4. **Operator Overloading**: 
   - C++ friend operators → C# static operators
   - C++ reference parameters → C# `ref` parameters where needed
   - Output stream `<<` → `ToString()` method override

5. **String Operations**:
   - `std::string::erase()` → `String.Substring()`
   - `std::string::length()` → `String.Length`
   - `std::to_string()` → `(value).ToString()`

6. **Vector Operations**:
   - `std::vector<int>` → `List<int>`
   - Array initialization syntax adjusted for C#

7. **Validation**:
   - `is_bigint()` → `IsBigInt()` (private method)
   - Exception handling remains similar

8. **Exception Handling**:
   - C++ `std::runtime_error` → C# `ArgumentException`, `DivideByZeroException`
   - Error messages adapted for C#

9. **Static Methods**:
   - All static arithmetic and utility methods preserved
   - Public wrapper methods added for external use

### Performance Characteristics

The C# implementation maintains similar algorithmic complexity to the C++ version:

- **Addition/Subtraction**: O(max(n, m))
- **Multiplication**: O(n*m)
- **Division**: O(log(divisor)) for small divisors
- **Square Root**: O(log(result)) with binary search
- **GCD**: O(log(min(a,b)))
- **Prime Check**: O(sqrt(n))

## Limitations

1. Floating-point operations are not supported (only integers)
2. Negative number support is limited to operations, not all properties
3. Very large numbers (100K+ digits) may experience performance degradation
4. Prime checking uses trial division and is slow for very large numbers

## Testing

The `Program.cs` file includes comprehensive tests covering:
- All arithmetic operations
- Comparison operators  
- Utility functions
- Edge cases (negative numbers, zero, large numbers)
- Mixed operations with regular integers

Run the test suite with:
```bash
dotnet run
```

## Original C++ Library Attribution

This library is a migration of the BigInteger Library created by Roshan Gupta (16-10-2020).
Original repository: https://github.com/roshanr1990/BigInteger-Library-Project

MIT License - See LICENSE file for details

## C# Migration

Migrated to C# maintaining full feature parity with the original C++ implementation.
