using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== BigInt Library C# Test Suite ===\n");

        // Create big integers
        BigInt a = new BigInt("56654250564056135415631554531554513813");
        BigInt b = new BigInt("60820564691661355463515465564664568");
        BigInt d = new BigInt(956486133);

        Console.WriteLine("Test Values:");
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"d = {d}\n");

        // ----- Addition Tests -----
        Console.WriteLine("=== ADDITION ===");
        BigInt c = a + b;
        Console.WriteLine($"a + b = {c}");

        c = a + 56242;
        Console.WriteLine($"a + 56242 = {c}");

        c = new BigInt(52) + new BigInt(98);
        Console.WriteLine($"52 + 98 = {c}");

        // ------ Subtraction Tests ------
        Console.WriteLine("\n=== SUBTRACTION ===");
        c = a - b;
        Console.WriteLine($"a - b = {c}");

        c = a - 56242;
        Console.WriteLine($"a - 56242 = {c}");

        c = new BigInt(52) - new BigInt(98);
        Console.WriteLine($"52 - 98 = {c}");

        // ------ Multiplication Tests ------
        Console.WriteLine("\n=== MULTIPLICATION ===");
        c = a * b;
        Console.WriteLine($"a * b = {c}");

        c = a * 56242;
        Console.WriteLine($"a * 56242 = {c}");

        c = new BigInt(52) * new BigInt(98);
        Console.WriteLine($"52 * 98 = {c}");

        // ------ Division Tests ------
        Console.WriteLine("\n=== DIVISION ===");
        c = a / b;
        Console.WriteLine($"a / b = {c}");

        c = a / 56242;
        Console.WriteLine($"a / 56242 = {c}");

        c = new BigInt(98) / new BigInt(56);
        Console.WriteLine($"98 / 56 = {c}");

        // ------ Modulus Tests ------
        Console.WriteLine("\n=== MODULUS ===");
        c = a % b;
        Console.WriteLine($"a % b = {c}");

        c = a % 56242;
        Console.WriteLine($"a % 56242 = {c}");

        c = new BigInt(98) % new BigInt(56);
        Console.WriteLine($"98 % 56 = {c}");

        // ------ Conditional Tests ------
        Console.WriteLine("\n=== CONDITIONAL OPERATORS ===");
        if (a > b)
        {
            Console.WriteLine("a > b: True");
        }
        else
        {
            Console.WriteLine("a > b: False");
        }

        if (b > a)
        {
            Console.WriteLine("b > a: True");
        }
        else
        {
            Console.WriteLine("b > a: False");
        }

        if (a == new BigInt("56654250564056135415631554531554513813"))
        {
            Console.WriteLine("a == 56654250564056135415631554531554513813: True");
        }

        if (a != b)
        {
            Console.WriteLine("a != b: True");
        }

        // ------ Utility Functions Tests ------
        Console.WriteLine("\n=== UTILITY FUNCTIONS ===");

        // Absolute value
        BigInt negNum = new BigInt(-123);
        Console.WriteLine($"Abs(-123) = {BigInt.Abs(negNum)}");

        // Power
        BigInt base2 = new BigInt(2);
        BigInt exp = new BigInt(10);
        Console.WriteLine($"2^10 = {BigInt.Pow(base2, exp)}");

        // Square root
        BigInt num = new BigInt("144");
        Console.WriteLine($"Sqrt(144) = {BigInt.Sqrt(num)}");

        // Log base 2
        BigInt log2Input = new BigInt("8");
        Console.WriteLine($"Log2(8) = {BigInt.Log2(log2Input)}");

        // Log base 10
        BigInt log10Input = new BigInt("1000");
        Console.WriteLine($"Log10(1000) = {BigInt.Log10(log10Input)}");

        // GCD
        BigInt num1 = new BigInt(48);
        BigInt num2 = new BigInt(18);
        Console.WriteLine($"GCD(48, 18) = {BigInt.GCD(num1, num2)}");

        // LCM
        Console.WriteLine($"LCM(48, 18) = {BigInt.LCM(num1, num2)}");

        // Factorial
        BigInt fact = new BigInt(5);
        Console.WriteLine($"Factorial(5) = {BigInt.Factorial(fact)}");

        // Reverse
        BigInt revNum = new BigInt("12345");
        Console.WriteLine($"Reverse(12345) = {BigInt.Reverse(revNum)}");

        // ------ Palindrome and Prime Tests ------
        Console.WriteLine("\n=== PALINDROME & PRIME CHECKS ===");
        BigInt palindrome = new BigInt("12321");
        Console.WriteLine($"IsPalindrome(12321) = {BigInt.IsPalindrome(palindrome)}");

        BigInt notPalindrome = new BigInt("12345");
        Console.WriteLine($"IsPalindrome(12345) = {BigInt.IsPalindrome(notPalindrome)}");

        BigInt prime = new BigInt(17);
        Console.WriteLine($"IsPrime(17) = {BigInt.IsPrime(prime)}");

        BigInt notPrime = new BigInt(18);
        Console.WriteLine($"IsPrime(18) = {BigInt.IsPrime(notPrime)}");

        // ------ Min/Max Tests ------
        Console.WriteLine("\n=== MIN/MAX FUNCTIONS ===");
        Console.WriteLine($"Max(a, b) = {BigInt.Max(a, b)}");
        Console.WriteLine($"Min(a, b) = {BigInt.Min(a, b)}");

        // ------ Increment/Decrement Tests ------
        Console.WriteLine("\n=== INCREMENT/DECREMENT ===");
        BigInt incTest = new BigInt(5);
        Console.WriteLine($"Initial value: {incTest}");
        incTest++;
        Console.WriteLine($"After ++: {incTest}");
        incTest--;
        Console.WriteLine($"After --: {incTest}");

        // ------ Compound Assignment Tests ------
        Console.WriteLine("\n=== COMPOUND ASSIGNMENT ===");
        BigInt comp = new BigInt(10);
        Console.WriteLine($"Initial: {comp}");
        comp += new BigInt(5);
        Console.WriteLine($"After += 5: {comp}");
        comp *= new BigInt(2);
        Console.WriteLine($"After *= 2: {comp}");
        comp -= new BigInt(10);
        Console.WriteLine($"After -= 10: {comp}");

        Console.WriteLine("\n=== All Tests Completed Successfully ===");
    }
}
