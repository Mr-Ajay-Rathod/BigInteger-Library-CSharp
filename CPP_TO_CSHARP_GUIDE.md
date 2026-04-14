# C++ to C# BigInt Library - Side-by-Side Comparison

This document provides side-by-side examples for developers familiar with the C++ version.

## Syntax Differences

### Creating Objects

#### C++ (Original)
```cpp
#include "bigint_function_definitions.h"

bigint a;                           // default = 0
bigint b("123456789");              // from string
bigint c(1000);                     // from int
bigint d(999999999LL);              // from long long
bigint e = b;                       // copy
```

#### C# (Migrated)
```csharp
BigInt a = new BigInt();            // default = 0
BigInt b = new BigInt("123456789"); // from string
BigInt c = new BigInt(1000);        // from int
BigInt d = new BigInt(999999999L);  // from long
BigInt e = new BigInt(b);           // copy
```

### Output

#### C++ (Original)
```cpp
std::cout << "Result: " << a << std::endl;
```

#### C# (Migrated)
```csharp
Console.WriteLine($"Result: {a}");
```

### Input (C++ Only - Not needed in C#)
```cpp
// C++ version supported input
std::cin >> a;

// C# equivalent: parse from user input
BigInt a = new BigInt(Console.ReadLine());
```

## Arithmetic Operations

### Addition

#### C++ (Original)
```cpp
bigint a("100");
bigint b("200");
bigint c = a + b;              // BigInt + BigInt = 300
bigint d = a + 50;             // BigInt + int = 150
bigint e = 30 + b;             // int + BigInt = 230
```

#### C# (Migrated)
```csharp
BigInt a = new BigInt("100");
BigInt b = new BigInt("200");
BigInt c = a + b;              // BigInt + BigInt = 300
BigInt d = a + 50;             // BigInt + int = 150
BigInt e = 30 + b;             // int + BigInt = 230
```

### Subtraction

#### C++ (Original)
```cpp
bigint a("500");
bigint b("200");
bigint c = a - b;              // 300
bigint d = a - 100;            // 400
bigint e = 1000 - b;           // 800
```

#### C# (Migrated)
```csharp
BigInt a = new BigInt("500");
BigInt b = new BigInt("200");
BigInt c = a - b;              // 300
BigInt d = a - 100;            // 400
BigInt e = 1000 - b;           // 800
```

### Multiplication

#### C++ (Original)
```cpp
bigint a("12");
bigint b("25");
bigint c = a * b;              // 300
bigint d = a * 10;             // 120
bigint e = 5 * b;              // 125
```

#### C# (Migrated)
```csharp
BigInt a = new BigInt("12");
BigInt b = new BigInt("25");
BigInt c = a * b;              // 300
BigInt d = a * 10;             // 120
BigInt e = 5 * b;              // 125
```

### Division

#### C++ (Original)
```cpp
bigint a("1000");
bigint b("25");
bigint c = a / b;              // 40
bigint d = a / 7;              // 142
```

#### C# (Migrated)
```csharp
BigInt a = new BigInt("1000");
BigInt b = new BigInt("25");
BigInt c = a / b;              // 40
BigInt d = a / 7;              // 142
```

### Modulus

#### C++ (Original)
```cpp
bigint a("100");
bigint b("30");
bigint c = a % b;              // 10
bigint d = a % 7;              // 2
```

#### C# (Migrated)
```csharp
BigInt a = new BigInt("100");
BigInt b = new BigInt("30");
BigInt c = a % b;              // 10
BigInt d = a % 7;              // 2
```

## Compound Assignments

### C++ (Original)
```cpp
bigint a("100");
a += 50;                        // a = 150
a -= 30;                        // a = 120
a *= 2;                         // a = 240
a /= 4;                         // a = 60
a %= 7;                         // a = 4
```

### C# (Migrated)
```csharp
BigInt a = new BigInt("100");
a += 50;                        // a = 150 (note: creates new instance)
a -= 30;                        // a = 120
a *= 2;                         // a = 240
a /= 4;                         // a = 60
a %= 7;                         // a = 4
```

## Increment and Decrement

### C++ (Original)
```cpp
bigint a("10");
++a;                            // pre-increment: a = 11, returns 11
bigint b = a++;                 // post-increment: b = 11, a = 12
--a;                            // pre-decrement: a = 11
bigint c = a--;                 // post-decrement: c = 11, a = 10
```

### C# (Migrated)
```csharp
BigInt a = new BigInt("10");
++a;                            // pre-increment: a = 11
BigInt b = a++;                 // post-increment: b = 11, a = 12
--a;                            // pre-decrement: a = 11
BigInt c = a--;                 // post-decrement: c = 11, a = 10
```

## Comparison Operators

### Greater Than / Less Than

#### C++ (Original)
```cpp
bigint a("100");
bigint b("200");

if (a > b) { /* ... */ }        // false
if (a < b) { /* ... */ }        // true
if (a >= b) { /* ... */ }       // false
if (a <= b) { /* ... */ }       // true
if (a == b) { /* ... */ }       // false
if (a != b) { /* ... */ }       // true

// With mixed types
if (a > 50) { /* ... */ }       // true
if (a < 50) { /* ... */ }       // false
```

#### C# (Migrated)
```csharp
BigInt a = new BigInt("100");
BigInt b = new BigInt("200");

if (a > b) { /* ... */ }        // false
if (a < b) { /* ... */ }        // true
if (a >= b) { /* ... */ }       // false
if (a <= b) { /* ... */ }       // true
if (a == b) { /* ... */ }       // false
if (a != b) { /* ... */ }       // true

// With mixed types
if (a > 50) { /* ... */ }       // true
if (a < 50) { /* ... */ }       // false
```

## Static Utility Functions

### Maximum and Minimum

#### C++ (Original)
```cpp
bigint a("100");
bigint b("200");
bigint max_val = big_max(a, b); // 200
bigint min_val = big_min(a, b); // 100
```

#### C# (Migrated)
```csharp
BigInt a = new BigInt("100");
BigInt b = new BigInt("200");
BigInt max_val = BigInt.Max(a, b);  // 200
BigInt min_val = BigInt.Min(a, b);  // 100
```

### Absolute Value

#### C++ (Original)
```cpp
bigint a("-123");
bigint pos = big_abs(a);        // 123
```

#### C# (Migrated)
```csharp
BigInt a = new BigInt("-123");
BigInt pos = BigInt.Abs(a);     // 123
```

### Power

#### C++ (Original)
```cpp
bigint base_val = to_bigint(2);
bigint exp = to_bigint(10);
bigint result = big_pow(base_val, exp);  // 1024
```

#### C# (Migrated)
```csharp
BigInt base_val = new BigInt(2);
BigInt exp = new BigInt(10);
BigInt result = BigInt.Pow(base_val, exp);  // 1024
```

### Square Root

#### C++ (Original)
```cpp
bigint a("144");
bigint root = big_sqrt(a);      // 12
```

#### C# (Migrated)
```csharp
BigInt a = new BigInt("144");
BigInt root = BigInt.Sqrt(a);   // 12
```

### Logarithm

#### C++ (Original)
```cpp
bigint a("8");
bigint log2 = big_log2(a);                  // 3
bigint log10 = big_log10(new BigInt("1000"));  // 3

bigint base_num = to_bigint(2);
bigint logval = big_logwithbase(a, base_num);  // 3
```

#### C# (Migrated)
```csharp
BigInt a = new BigInt("8");
BigInt log2 = BigInt.Log2(a);               // 3
BigInt log10 = BigInt.Log10(new BigInt("1000"));  // 3

BigInt base_num = new BigInt(2);
BigInt logval = BigInt.LogWithBase(a, base_num);  // 3
```

### Antilogarithm

#### C++ (Original)
```cpp
bigint a("3");
bigint pow2 = big_antilog2(a);      // 8 (2^3)
bigint pow10 = big_antilog10(a);    // 1000 (10^3)
```

#### C# (Migrated)
```csharp
BigInt a = new BigInt("3");
BigInt pow2 = BigInt.Antilog2(a);   // 8 (2^3)
BigInt pow10 = BigInt.Antilog10(a); // 1000 (10^3)
```

## Number Theory Functions

### GCD and LCM

#### C++ (Original)
```cpp
bigint a("48");
bigint b("18");
bigint gcd_val = big_gcd(a, b);    // 6
bigint lcm_val = big_lcm(a, b);    // 144
```

#### C# (Migrated)
```csharp
BigInt a = new BigInt("48");
BigInt b = new BigInt("18");
BigInt gcd_val = BigInt.GCD(a, b);  // 6
BigInt lcm_val = BigInt.LCM(a, b);  // 144
```

### Factorial

#### C++ (Original)
```cpp
bigint n("5");
bigint fact_val = big_fact(n);      // 120
```

#### C# (Migrated)
```csharp
BigInt n = new BigInt("5");
BigInt fact_val = BigInt.Factorial(n);  // 120
```

### Prime Check

#### C++ (Original)
```cpp
bigint a("17");
if (big_isPrime(a)) {
    std::cout << "17 is prime" << std::endl;
}
```

#### C# (Migrated)
```csharp
BigInt a = new BigInt("17");
if (BigInt.IsPrime(a)) {
    Console.WriteLine("17 is prime");
}
```

### Palindrome Check

#### C++ (Original)
```cpp
bigint a("12321");
if (big_isPalindrome(a)) {
    std::cout << "12321 is palindrome" << std::endl;
}
```

#### C# (Migrated)
```csharp
BigInt a = new BigInt("12321");
if (BigInt.IsPalindrome(a)) {
    Console.WriteLine("12321 is palindrome");
}
```

## Other Utilities

### Reverse

#### C++ (Original)
```cpp
bigint a("12345");
bigint rev = big_reverse(a);       // 54321
```

#### C# (Migrated)
```csharp
BigInt a = new BigInt("12345");
BigInt rev = BigInt.Reverse(a);    // 54321
```

### Swap

#### C++ (Original)
```cpp
bigint a("100");
bigint b("200");
big_swap(a, b);                     // a=200, b=100
```

#### C# (Migrated)
```csharp
BigInt a = new BigInt("100");
BigInt b = new BigInt("200");
BigInt.Swap(ref a, ref b);         // a=200, b=100
```

## Macro Replacements

The C++ version used macros for convenience:

### C++ Macros
```cpp
#define big_abs bigint::_big_abs
#define big_pow bigint::_big_pow
#define big_sqrt bigint::_big_sqrt
// ... many more
```

### C# Direct Method Calls
In C#, just use the static methods directly:
```csharp
BigInt.Abs(...)
BigInt.Pow(...)
BigInt.Sqrt(...)
// ... etc
```

## Error Handling Differences

### C++ (Original)
```cpp
try {
    bigint a("100");
    bigint b = a / to_bigint(0);  // May fail
} catch (std::runtime_error &e) {
    std::cerr << e.what() << std::endl;
}
```

### C# (Migrated)
```csharp
try {
    BigInt a = new BigInt("100");
    BigInt b = a / new BigInt(0);  // Throws
} catch (DivideByZeroException ex) {
    Console.WriteLine(ex.Message);
}
```

## Complete Program Examples

### C++ Example
```cpp
#include <iostream>
#include "bigint_function_definitions.h"
using namespace std;

int main() {
    bigint a("56654250564056135415631554531554513813");
    bigint b("60820564691661355463515465564664568");
    
    cout << "a + b = " << (a + b) << endl;
    cout << "a * b = " << (a * b) << endl;
    cout << "a / b = " << (a / b) << endl;
    
    if (a > b) {
        cout << "a is greater than b" << endl;
    }
    
    return 0;
}
```

### C# Equivalent
```csharp
using System;

class Program {
    static void Main() {
        BigInt a = new BigInt("56654250564056135415631554531554513813");
        BigInt b = new BigInt("60820564691661355463515465564664568");
        
        Console.WriteLine($"a + b = {a + b}");
        Console.WriteLine($"a * b = {a * b}");
        Console.WriteLine($"a / b = {a / b}");
        
        if (a > b) {
            Console.WriteLine("a is greater than b");
        }
    }
}
```

## Key Takeaways

| Aspect | C++ | C# |
|--------|-----|-----|
| Object Creation | `bigint a;` | `BigInt a = new BigInt();` |
| Output | `std::cout << a` | `Console.WriteLine(a)` |
| Function Prefix | `big_*` macros | `BigInt.*` static methods |
| Exception Type | `std::runtime_error` | `ArgumentException` / `DivideByZeroException` |
| Swap Signature | `big_swap(a, b)` | `BigInt.Swap(ref a, ref b)` |
| Include Files | Header files | Single `BigInt.cs` |
| Namespace | Global | Can add to namespace if desired |

## Migration Checklist

If migrating code from C++ to C#:

- [ ] Replace `#include` directives with appropriate using statements (if `BigInt` is in a namespace)
- [ ] Replace `bigint` with `BigInt`
- [ ] Replace `new bigint()` with `new BigInt()`
- [ ] Replace `big_*` macros with `BigInt.*` static methods
- [ ] Replace `std::cout` with `Console.WriteLine()`
- [ ] Replace exception handling from `std::runtime_error` to appropriate C# exceptions
- [ ] Add `new` keyword for BigInt construction
- [ ] Update macro definitions to direct method calls

## Questions?

Refer to `QUICKSTART.md` for common usage patterns or `README.md` for complete documentation.
