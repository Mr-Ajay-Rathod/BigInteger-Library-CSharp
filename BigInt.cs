/*
    BigInt.cs

    BigInt Library for C#

    MIT License

    Migrated from C++ BigInteger Library by Roshan Gupta on 16-10-2020
    
    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class BigInt
{
    private string str; // Only data member for strong Big Integer as String. [For signed int, str[0] = '-']

    #region Constructors

    /// <summary>
    /// Default constructor initializes BigInt to 0
    /// </summary>
    public BigInt()
    {
        str = "0";
    }

    /// <summary>
    /// Constructor from string
    /// </summary>
    public BigInt(string s)
    {
        if (!IsBigInt(s))
            throw new ArgumentException("Invalid Big Integer has been provided.");
        str = s;
    }

    /// <summary>
    /// Constructor from long long
    /// </summary>
    public BigInt(long n)
    {
        str = n.ToString();
    }

    /// <summary>
    /// Constructor from int
    /// </summary>
    public BigInt(int n)
    {
        str = n.ToString();
    }

    /// <summary>
    /// Copy constructor
    /// </summary>
    public BigInt(BigInt n)
    {
        str = n.str;
    }

    #endregion

    #region Object Overrides

    public override string ToString()
    {
        return str;
    }

    public override bool Equals(object? obj)
    {
        if (obj is BigInt other)
            return str == other.str;
        return false;
    }

    public override int GetHashCode()
    {
        return str.GetHashCode();
    }

    #endregion

    #region Arithmetic Operator Overloads

    // Addition operators
    public static BigInt operator +(BigInt n1, BigInt n2)
    {
        BigInt ans = new BigInt();
        ans.str = Add(n1.str, n2.str);
        return ans;
    }

    public static BigInt operator +(BigInt n1, int n2)
    {
        BigInt ans = new BigInt();
        ans.str = Add(n1.str, n2.ToString());
        return ans;
    }

    public static BigInt operator +(int n1, BigInt n2)
    {
        BigInt ans = new BigInt();
        ans.str = Add(n2.str, n1.ToString());
        return ans;
    }

    public static BigInt operator +(BigInt n1, long n2)
    {
        BigInt ans = new BigInt();
        ans.str = Add(n1.str, n2.ToString());
        return ans;
    }

    public static BigInt operator +(long n1, BigInt n2)
    {
        BigInt ans = new BigInt();
        ans.str = Add(n2.str, n1.ToString());
        return ans;
    }

    // Subtraction operators
    public static BigInt operator -(BigInt n1, BigInt n2)
    {
        BigInt ans = new BigInt();
        ans.str = Subtract(n1.str, n2.str);
        return ans;
    }

    public static BigInt operator -(BigInt n1, int n2)
    {
        BigInt ans = new BigInt();
        ans.str = Subtract(n1.str, n2.ToString());
        return ans;
    }

    public static BigInt operator -(int n1, BigInt n2)
    {
        BigInt ans = new BigInt();
        ans.str = Subtract(n1.ToString(), n2.str);
        return ans;
    }

    public static BigInt operator -(BigInt n1, long n2)
    {
        BigInt ans = new BigInt();
        ans.str = Subtract(n1.str, n2.ToString());
        return ans;
    }

    public static BigInt operator -(long n1, BigInt n2)
    {
        BigInt ans = new BigInt();
        ans.str = Subtract(n1.ToString(), n2.str);
        return ans;
    }

    // Multiplication operators
    public static BigInt operator *(BigInt n1, BigInt n2)
    {
        BigInt ans = new BigInt();
        ans.str = Multiply(n1.str, n2.str);
        return ans;
    }

    public static BigInt operator *(BigInt n1, int n2)
    {
        BigInt ans = new BigInt();
        ans.str = Multiply(n1.str, n2.ToString());
        return ans;
    }

    public static BigInt operator *(int n1, BigInt n2)
    {
        BigInt ans = new BigInt();
        ans.str = Multiply(n1.ToString(), n2.str);
        return ans;
    }

    public static BigInt operator *(BigInt n1, long n2)
    {
        BigInt ans = new BigInt();
        ans.str = Multiply(n1.str, n2.ToString());
        return ans;
    }

    public static BigInt operator *(long n1, BigInt n2)
    {
        BigInt ans = new BigInt();
        ans.str = Multiply(n1.ToString(), n2.str);
        return ans;
    }

    // Division operators
    public static BigInt operator /(BigInt n1, BigInt n2)
    {
        BigInt ans = new BigInt();
        ans.str = Divide(n1.str, n2.str);
        return ans;
    }

    public static BigInt operator /(BigInt n1, int n2)
    {
        BigInt ans = new BigInt();
        ans.str = Divide(n1.str, n2.ToString());
        return ans;
    }

    public static BigInt operator /(int n1, BigInt n2)
    {
        BigInt ans = new BigInt();
        ans.str = Divide(n1.ToString(), n2.str);
        return ans;
    }

    public static BigInt operator /(BigInt n1, long n2)
    {
        BigInt ans = new BigInt();
        ans.str = Divide(n1.str, n2.ToString());
        return ans;
    }

    public static BigInt operator /(long n1, BigInt n2)
    {
        BigInt ans = new BigInt();
        ans.str = Divide(n1.ToString(), n2.str);
        return ans;
    }

    // Modulus operators
    public static BigInt operator %(BigInt n1, BigInt n2)
    {
        BigInt ans = new BigInt();
        ans.str = Mod(n1.str, n2.str);
        return ans;
    }

    public static BigInt operator %(BigInt n1, int n2)
    {
        BigInt ans = new BigInt();
        ans.str = Mod(n1.str, n2.ToString());
        return ans;
    }

    public static BigInt operator %(int n1, BigInt n2)
    {
        BigInt ans = new BigInt();
        ans.str = Mod(n1.ToString(), n2.str);
        return ans;
    }

    public static BigInt operator %(BigInt n1, long n2)
    {
        BigInt ans = new BigInt();
        ans.str = Mod(n1.str, n2.ToString());
        return ans;
    }

    public static BigInt operator %(long n1, BigInt n2)
    {
        BigInt ans = new BigInt();
        ans.str = Mod(n1.ToString(), n2.str);
        return ans;
    }

    #endregion

    #region Increment/Decrement Operators

    public static BigInt operator ++(BigInt n)
    {
        n.str = Add(n.str, "1");
        return n;
    }

    public static BigInt operator --(BigInt n)
    {
        n.str = Subtract(n.str, "1");
        return n;
    }

    #endregion

    #region Comparison Operators

    // Greater than
    public static bool operator >(BigInt n1, BigInt n2)
    {
        return IsStrictlyMaximum(n1.str, n2.str);
    }

    public static bool operator >(BigInt n1, int n2)
    {
        return IsStrictlyMaximum(n1.str, n2.ToString());
    }

    public static bool operator >(int n1, BigInt n2)
    {
        return IsStrictlyMaximum(n1.ToString(), n2.str);
    }

    public static bool operator >(BigInt n1, long n2)
    {
        return IsStrictlyMaximum(n1.str, n2.ToString());
    }

    public static bool operator >(long n1, BigInt n2)
    {
        return IsStrictlyMaximum(n1.ToString(), n2.str);
    }

    // Less than
    public static bool operator <(BigInt n1, BigInt n2)
    {
        return IsStrictlyMinimum(n1.str, n2.str);
    }

    public static bool operator <(BigInt n1, int n2)
    {
        return IsStrictlyMinimum(n1.str, n2.ToString());
    }

    public static bool operator <(int n1, BigInt n2)
    {
        return IsStrictlyMinimum(n1.ToString(), n2.str);
    }

    public static bool operator <(BigInt n1, long n2)
    {
        return IsStrictlyMinimum(n1.str, n2.ToString());
    }

    public static bool operator <(long n1, BigInt n2)
    {
        return IsStrictlyMinimum(n1.ToString(), n2.str);
    }

    // Greater than or equal
    public static bool operator >=(BigInt n1, BigInt n2)
    {
        return IsMaximum(n1.str, n2.str);
    }

    public static bool operator >=(BigInt n1, int n2)
    {
        return IsMaximum(n1.str, n2.ToString());
    }

    public static bool operator >=(int n1, BigInt n2)
    {
        return IsMaximum(n1.ToString(), n2.str);
    }

    public static bool operator >=(BigInt n1, long n2)
    {
        return IsMaximum(n1.str, n2.ToString());
    }

    public static bool operator >=(long n1, BigInt n2)
    {
        return IsMaximum(n1.ToString(), n2.str);
    }

    // Less than or equal
    public static bool operator <=(BigInt n1, BigInt n2)
    {
        return IsMinimum(n1.str, n2.str);
    }

    public static bool operator <=(BigInt n1, int n2)
    {
        return IsMinimum(n1.str, n2.ToString());
    }

    public static bool operator <=(int n1, BigInt n2)
    {
        return IsMinimum(n1.ToString(), n2.str);
    }

    public static bool operator <=(BigInt n1, long n2)
    {
        return IsMinimum(n1.str, n2.ToString());
    }

    public static bool operator <=(long n1, BigInt n2)
    {
        return IsMinimum(n1.ToString(), n2.str);
    }

    // Equality
    public static bool operator ==(BigInt n1, BigInt n2)
    {
        return n1.str == n2.str;
    }

    public static bool operator ==(BigInt n1, int n2)
    {
        return n1.str == n2.ToString();
    }

    public static bool operator ==(int n1, BigInt n2)
    {
        return n1.ToString() == n2.str;
    }

    public static bool operator ==(BigInt n1, long n2)
    {
        return n1.str == n2.ToString();
    }

    public static bool operator ==(long n1, BigInt n2)
    {
        return n1.ToString() == n2.str;
    }

    // Inequality
    public static bool operator !=(BigInt n1, BigInt n2)
    {
        return n1.str != n2.str;
    }

    public static bool operator !=(BigInt n1, int n2)
    {
        return n1.str != n2.ToString();
    }

    public static bool operator !=(int n1, BigInt n2)
    {
        return n1.ToString() != n2.str;
    }

    public static bool operator !=(BigInt n1, long n2)
    {
        return n1.str != n2.ToString();
    }

    public static bool operator !=(long n1, BigInt n2)
    {
        return n1.ToString() != n2.str;
    }

    #endregion

    #region Internal Arithmetic Functions

    /// <summary>
    /// Validates if a string represents a valid big integer
    /// </summary>
    private static bool IsBigInt(string s)
    {
        if (string.IsNullOrEmpty(s))
            return false;

        string numStr = s;
        if (s[0] == '-')
            numStr = s.Substring(1);

        if (string.IsNullOrEmpty(numStr))
            return false;

        return numStr.All(c => c >= '0' && c <= '9');
    }

    /// <summary>
    /// Removes leading zeros from a number string
    /// </summary>
    private static string Trim(string s)
    {
        if (s == "0")
            return s;

        if (s[0] == '-')
        {
            string numPart = s.Substring(1).TrimStart('0');
            if (string.IsNullOrEmpty(numPart) || numPart == "")
                return "0";
            return "-" + numPart;
        }

        string trimmed = s.TrimStart('0');
        return string.IsNullOrEmpty(trimmed) ? "0" : trimmed;
    }

    /// <summary>
    /// Addition of two big integers represented as strings
    /// </summary>
    private static string Add(string str1, string str2)
    {
        int str1Len = str1.Length;
        int str2Len = str2.Length;
        string sum = "";

        if (str1Len == 0 && str2Len == 0)
        {
            sum = "0";
        }
        else if (str1[0] == '-' && str2[0] == '-')
        {
            if (str1Len == 1 && str2Len == 1)
            {
                sum = "0";
            }
            else
            {
                sum = "-" + Add(str1.Substring(1), str2.Substring(1));
            }
        }
        else if (str1[0] == '-')
        {
            sum = Subtract(str2, str1.Substring(1));
        }
        else if (str2[0] == '-')
        {
            sum = Subtract(str1, str2.Substring(1));
        }
        else
        {
            int carry = 0;
            int i = str1Len - 1;
            int j = str2Len - 1;

            while (i >= 0 && j >= 0)
            {
                int trackSum = (str1[i] - '0') + (str2[j] - '0') + carry;
                carry = trackSum / 10;
                sum = (trackSum % 10) + sum;
                i--;
                j--;
            }

            while (i >= 0)
            {
                int trackSum = (str1[i] - '0') + carry;
                carry = trackSum / 10;
                sum = (trackSum % 10) + sum;
                i--;
            }

            while (j >= 0)
            {
                int trackSum = (str2[j] - '0') + carry;
                carry = trackSum / 10;
                sum = (trackSum % 10) + sum;
                j--;
            }

            if (carry > 0)
            {
                sum = carry + sum;
            }
        }

        return Trim(sum);
    }

    /// <summary>
    /// Subtraction of two big integers represented as strings
    /// </summary>
    private static string Subtract(string str1, string str2)
    {
        int str1Len = str1.Length;
        int str2Len = str2.Length;
        string sum = "";

        if (str1 == str2)
        {
            return "0";
        }
        else if (str1[0] == '-' && str2[0] == '-')
        {
            if (str2Len == 1 && str1Len == 1)
            {
                sum = "0";
            }
            else
            {
                string temp = Subtract(str2.Substring(1), str1.Substring(1));
                string mx = Maximum(str2.Substring(1), str1.Substring(1));
                if (temp[0] != '-' && mx == str1.Substring(1))
                    sum = "-" + temp;
                else
                    sum = temp;
            }
        }
        else if (str1[0] == '-')
        {
            sum = "-" + Add(str1.Substring(1), str2);
        }
        else if (str2[0] == '-')
        {
            sum = Add(str1, str2.Substring(1));
        }
        else
        {
            if (str1Len < str2Len)
            {
                return "-" + Subtract(str2, str1);
            }
            else if (str1Len == str2Len)
            {
                string mx = Maximum(str1, str2);
                if (mx == str2)
                {
                    return "-" + Subtract(str2, str1);
                }
            }

            int carry = 0;
            int i = str1Len - 1;
            int j = str2Len - 1;

            while (i >= 0 || j >= 0)
            {
                int val1 = (i >= 0) ? (str1[i] - '0') : 0;
                int val2 = (j >= 0) ? (str2[j] - '0') : 0;

                int trackSum = val1 - val2 - carry;
                if (trackSum < 0)
                {
                    trackSum += 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }

                sum = trackSum + sum;
                i--;
                j--;
            }
        }

        return Trim(sum);
    }

    /// <summary>
    /// Multiplication of two big integers
    /// </summary>
    private static string Multiply(string str1, string str2)
    {
        bool toAddNeg = false;
        int str1Len = str1.Length;
        int str2Len = str2.Length;
        string ans = "";

        if (str1[0] == '-' && str2[0] == '-')
        {
            ans = Multiply(str1.Substring(1), str2.Substring(1));
        }
        else if (str1[0] == '-')
        {
            toAddNeg = true;
            ans = Multiply(str1.Substring(1), str2);
        }
        else if (str2[0] == '-')
        {
            toAddNeg = true;
            ans = Multiply(str1, str2.Substring(1));
        }
        else
        {
            if (str1Len == 0 || str2Len == 0)
                return "0";

            List<int> result = new List<int>(new int[str1Len + str2Len]);
            int iN1 = 0;

            for (int i = str1Len - 1; i >= 0; i--)
            {
                int carry = 0;
                int n1 = str1[i] - '0';
                int iN2 = 0;

                for (int j = str2Len - 1; j >= 0; j--)
                {
                    int n2 = str2[j] - '0';
                    int sum = n1 * n2 + result[iN1 + iN2] + carry;
                    carry = sum / 10;
                    result[iN1 + iN2] = sum % 10;
                    iN2++;
                }

                if (carry > 0)
                    result[iN1 + iN2] += carry;

                iN1++;
            }

            int idx = result.Count - 1;
            while (idx >= 0 && result[idx] == 0)
                idx--;

            if (idx == -1)
                return "0";

            while (idx >= 0)
                ans += result[idx--];
        }

        if (toAddNeg && ans[0] != '0')
        {
            ans = '-' + ans;
        }

        return ans;
    }

    /// <summary>
    /// Division of two big integers
    /// </summary>
    private static string Divide(string str1, string str2)
    {
        string ans = "";

        if (str2 == "0")
        {
            throw new DivideByZeroException("Division by zero");
        }
        else if (str1 == str2)
        {
            return "1";
        }
        else if (str1[0] == '-' && str2[0] == '-')
        {
            ans = Divide(str1.Substring(1), str2.Substring(1));
        }
        else if (str1[0] == '-')
        {
            string temp = Divide(str1.Substring(1), str2);
            ans = (temp == "0") ? temp : '-' + temp;
        }
        else if (str2[0] == '-')
        {
            string temp = Divide(str1, str2.Substring(1));
            ans = (temp == "0") ? temp : '-' + temp;
        }
        else
        {
            if (str2 == "1")
                return str1;

            if (IsStrictlyMaximum(str2, str1))
            {
                return "0";
            }

            if (str2.Length <= 19)
            {
                if (ulong.TryParse(str2, out ulong divisor))
                {
                    ans = ShortDivide(str1, divisor);
                }
            }
            else
            {
                ans = "0";
                string count = "0";

                while (str1 == Maximum(str1, str2))
                {
                    int lenDiff = str1.Length - str2.Length;
                    if (lenDiff > 0 && str1[0] > str2[0])
                    {
                        count = Add(count, Pow("10", lenDiff.ToString()));
                        str1 = Subtract(str1, Multiply(str2, Pow("10", lenDiff.ToString())));
                    }
                    else if (lenDiff > 0)
                    {
                        count = Add(count, Pow("10", (lenDiff - 1).ToString()));
                        str1 = Subtract(str1, Multiply(str2, Pow("10", (lenDiff - 1).ToString())));
                    }
                    else
                    {
                        count = Add(count, "1");
                        str1 = Subtract(str1, str2);
                    }
                }
                ans = count;
            }
        }

        return ans;
    }

    /// <summary>
    /// Division by an unsigned long long integer
    /// </summary>
    private static string ShortDivide(string s1, ulong divisor)
    {
        string ans = "";
        int idx = 0;
        ulong temp = (ulong)(s1[idx] - '0');

        while (temp < divisor && idx < s1.Length - 1)
        {
            temp = temp * 10 + (ulong)(s1[++idx] - '0');
        }

        while (s1.Length > idx)
        {
            ans += (temp / divisor);
            temp = (temp % divisor) * 10;
            if (idx < s1.Length - 1)
                temp += (ulong)(s1[++idx] - '0');
            else
                idx++;
        }

        if (ans.Length == 0)
            return "0";

        return ans;
    }

    /// <summary>
    /// Modulo operation
    /// </summary>
    private static string Mod(string str1, string str2)
    {
        string ans = Subtract(str1, Multiply(Divide(str1, str2), str2));
        return ans;
    }

    #endregion

    #region Comparison Functions

    /// <summary>
    /// Returns maximum of two numbers
    /// </summary>
    private static string Maximum(string str1, string str2)
    {
        bool bothNeg = false;
        bool isMax1 = false;

        if (str1[0] == '-' && str2[0] == '-')
        {
            bothNeg = true;
            str1 = str1.Substring(1);
            str2 = str2.Substring(1);
        }
        else if (str1[0] == '-')
        {
            return Trim(str2);
        }
        else if (str2[0] == '-')
        {
            return Trim(str1);
        }

        int str1Len = str1.Length;
        int str2Len = str2.Length;

        if (str1Len == str2Len)
        {
            for (int i = 0; i < str1Len; i++)
            {
                if (str1[i] != str2[i])
                {
                    isMax1 = (str1[i] > str2[i]);
                    break;
                }
            }
        }
        else
        {
            isMax1 = (str1Len > str2Len);
        }

        if (bothNeg)
        {
            return isMax1 ? ("-" + Trim(str2)) : ("-" + Trim(str1));
        }
        else
        {
            return isMax1 ? Trim(str1) : Trim(str2);
        }
    }

    /// <summary>
    /// Returns minimum of two numbers
    /// </summary>
    private static string Minimum(string str1, string str2)
    {
        string ans = Maximum(str1, str2);
        return (ans == str1) ? str2 : str1;
    }

    /// <summary>
    /// Checks if str1 >= str2
    /// </summary>
    private static bool IsMaximum(string str1, string str2)
    {
        return str1 == Maximum(str1, str2);
    }

    /// <summary>
    /// Checks if str1 <= str2
    /// </summary>
    private static bool IsMinimum(string str1, string str2)
    {
        return str2 == Maximum(str1, str2);
    }

    /// <summary>
    /// Checks if str1 > str2
    /// </summary>
    private static bool IsStrictlyMaximum(string str1, string str2)
    {
        if (str1 == str2)
            return false;
        return str1 == Maximum(str1, str2);
    }

    /// <summary>
    /// Checks if str1 < str2
    /// </summary>
    private static bool IsStrictlyMinimum(string str1, string str2)
    {
        if (str1 == str2)
            return false;
        return str2 == Maximum(str1, str2);
    }

    #endregion

    #region Utility Functions

    /// <summary>
    /// Returns absolute value
    /// </summary>
    public static BigInt Abs(BigInt a)
    {
        BigInt ans = new BigInt();
        ans.str = (a.str[0] == '-') ? a.str.Substring(1) : a.str;
        return ans;
    }

    /// <summary>
    /// Returns a^b (power)
    /// </summary>
    public static BigInt Pow(BigInt a, BigInt b)
    {
        BigInt ans = new BigInt();
        ans.str = Pow(a.str, b.str);
        return ans;
    }

    private static string Pow(string str1, string str2)
    {
        if (str2 == "0")
        {
            return "1";
        }
        else if (str1 == "0")
        {
            return (str2[0] == '-') ? "0" : "0";
        }
        else if (str1[0] == '-' && str2[0] == '-')
        {
            if (str1 == "-1" && str2 == "-1")
            {
                return "-1";
            }
            else if (str1 == "-1")
            {
                int lastDigit = str2[str2.Length - 1] - '0';
                return (lastDigit & 1) == 1 ? "-1" : "1";
            }
            else
            {
                return "0";
            }
        }
        else if (str1[0] == '-')
        {
            int lastDigit = str2[str2.Length - 1] - '0';
            string result = Pow(str1.Substring(1), str2);
            return ((lastDigit & 1) == 1) ? '-' + result : result;
        }
        else if (str2[0] == '-')
        {
            return (str1 == "1") ? str1 : "0";
        }
        else
        {
            string initStr1 = str1;
            while (str2 != "1")
            {
                str1 = Multiply(str1, initStr1);
                str2 = Subtract(str2, "1");
            }
            return str1;
        }
    }

    /// <summary>
    /// Returns square root
    /// </summary>
    public static BigInt Sqrt(BigInt a)
    {
        BigInt ans = new BigInt();
        ans.str = Sqrt(a.str);
        return ans;
    }

    private static string Sqrt(string s)
    {
        if (s[0] == '-')
            return s;

        if (s == "0")
            return "0";

        int sLen = s.Length;
        string mid = "";
        string high, low, square;
        int ansLen = sLen >> 1;

        if ((sLen & 1) == 1)
        {
            low = Pow("10", ansLen.ToString());
            high = Pow("10", (ansLen + 1).ToString());
        }
        else
        {
            low = Pow("10", (ansLen - 1).ToString());
            high = Pow("10", ansLen.ToString());
        }

        string prev = "";
        while (true)
        {
            mid = Divide(Add(high, low), "2");
            square = Multiply(mid, mid);

            if (prev == mid || 
                (Maximum(Add(square, mid), s) == Add(square, mid) && Maximum(square, s) == s) || 
                high == low)
            {
                break;
            }

            if (Maximum(square, s) == s)
            {
                low = mid;
            }
            else if (Maximum(square, s) == square)
            {
                high = mid;
            }

            prev = mid;
        }

        return mid;
    }

    /// <summary>
    /// Returns log base 2
    /// </summary>
    public static BigInt Log2(BigInt a)
    {
        BigInt ans = new BigInt();
        ans.str = Log2(a.str);
        return ans;
    }

    private static string Log2(string s)
    {
        if (s == "0")
            throw new ArgumentException("log(0) is undefined");

        if (s[0] == '-')
            throw new ArgumentException("log of negative number is not allowed");

        string logVal = "-1";
        while (s != "0")
        {
            logVal = Add(logVal, "1");
            s = Divide(s, "2");
        }
        return logVal;
    }

    /// <summary>
    /// Returns log base 10
    /// </summary>
    public static BigInt Log10(BigInt a)
    {
        BigInt ans = new BigInt();
        ans.str = Log10(a.str);
        return ans;
    }

    private static string Log10(string s)
    {
        if (s == "0")
            throw new ArgumentException("log(0) is undefined");

        if (s[0] == '-')
            throw new ArgumentException("log of negative number is not allowed");

        return (s.Length - 1).ToString();
    }

    /// <summary>
    /// Returns log with custom base
    /// </summary>
    public static BigInt LogWithBase(BigInt val, BigInt baseNum)
    {
        BigInt ans = new BigInt();
        ans.str = Divide(Log2(val.str), Log2(baseNum.str));
        return ans;
    }

    /// <summary>
    /// Returns 2^a (antilog base 2)
    /// </summary>
    public static BigInt Antilog2(BigInt a)
    {
        BigInt ans = new BigInt();
        ans.str = Pow("2", a.str);
        return ans;
    }

    /// <summary>
    /// Returns 10^a (antilog base 10)
    /// </summary>
    public static BigInt Antilog10(BigInt a)
    {
        BigInt ans = new BigInt();
        ans.str = Pow("10", a.str);
        return ans;
    }

    /// <summary>
    /// Swaps two BigInts
    /// </summary>
    public static void Swap(ref BigInt a, ref BigInt b)
    {
        string temp = a.str;
        a.str = b.str;
        b.str = temp;
    }

    /// <summary>
    /// Returns reversed number
    /// </summary>
    public static BigInt Reverse(BigInt a)
    {
        BigInt ans = new BigInt();
        ans.str = Reverse(a.str);
        return ans;
    }

    private static string Reverse(string s)
    {
        bool hasNeg = false;
        if (s[0] == '-')
        {
            s = s.Substring(1);
            hasNeg = true;
        }

        char[] arr = s.ToCharArray();
        System.Array.Reverse(arr);
        string reversed = new string(arr);

        return hasNeg ? "-" + reversed : reversed;
    }

    /// <summary>
    /// Returns GCD of two numbers
    /// </summary>
    public static BigInt GCD(BigInt a, BigInt b)
    {
        BigInt ans = new BigInt();
        ans.str = GCD(a.str, b.str);
        return ans;
    }

    private static string GCD(string str1, string str2)
    {
        if (IsStrictlyMaximum(str2, str1))
        {
            string temp = str1;
            str1 = str2;
            str2 = temp;
        }

        while (IsStrictlyMaximum(str2, "0"))
        {
            string temp = Mod(str1, str2);
            str1 = str2;
            str2 = temp;
        }

        return str1;
    }

    /// <summary>
    /// Returns LCM of two numbers
    /// </summary>
    public static BigInt LCM(BigInt a, BigInt b)
    {
        BigInt ans = new BigInt();
        ans.str = Divide(Multiply(a.str, b.str), GCD(a.str, b.str));
        return ans;
    }

    /// <summary>
    /// Returns factorial
    /// </summary>
    public static BigInt Factorial(BigInt a)
    {
        BigInt ans = new BigInt();
        ans.str = Factorial(a.str);
        return ans;
    }

    private static string Factorial(string s)
    {
        if (s[0] == '-')
            throw new ArgumentException("Factorial of negative number is not defined");

        if (s == "0")
            return "1";

        string ans = "1";
        while (s != "0")
        {
            ans = Multiply(ans, s);
            s = Subtract(s, "1");
        }

        return ans;
    }

    /// <summary>
    /// Checks if number is palindrome
    /// </summary>
    public static bool IsPalindrome(BigInt a)
    {
        return IsPalindrome(a.str);
    }

    private static bool IsPalindrome(string s)
    {
        if (s[0] == '-')
            s = s.Substring(1);

        int beg = 0;
        int end = s.Length - 1;

        while (beg < end)
        {
            if (s[beg] != s[end])
                return false;
            beg++;
            end--;
        }

        return true;
    }

    /// <summary>
    /// Checks if number is prime
    /// </summary>
    public static bool IsPrime(BigInt a)
    {
        return IsPrime(a.str);
    }

    private static bool IsPrime(string s)
    {
        if (Maximum(s, "2") != s)
            return false;

        string sqrtVal = Sqrt(s);
        string i = "2";

        while (IsMaximum(sqrtVal, i))
        {
            if (Mod(s, i) == "0")
                return false;
            i = Add(i, "1");
        }

        return true;
    }

    /// <summary>
    /// Returns maximum of two BigInts
    /// </summary>
    public static BigInt Max(BigInt a, BigInt b)
    {
        BigInt ans = new BigInt();
        ans.str = Maximum(a.str, b.str);
        return ans;
    }

    /// <summary>
    /// Returns minimum of two BigInts
    /// </summary>
    public static BigInt Min(BigInt a, BigInt b)
    {
        BigInt ans = new BigInt();
        ans.str = Minimum(a.str, b.str);
        return ans;
    }

    #endregion
}
