public static class IntegerExtensions
{
    // ************************
    /// <summary>
    /// Checks if the number is between low and high inclusive.
    /// </summary>
    /// <param name="nbr"></param>
    /// <param name="low"></param>
    /// <param name="high"></param>
    /// <returns></returns>
    public static bool Between(this int nbr, int low, int high)
    {
        if (nbr < low)
        {
            return false;
        }

        if (nbr > high)
        {
            return false;
        }

        return true;
    }

    // ************************
    /// <summary>
    /// Return the result of input & ~mask, which is the bits of input with the bits of mask cleared.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="mask"></param>
    /// <returns></returns>
    public static int BinaryMask(this int input, int mask)
    {
        return input & ~mask;
    }

    // ************************
    /// <summary>
    /// Clamps the number to be between lower and upper inclusive. If the number is less than lower, it returns
    /// lower. If the number is greater than upper, it returns upper. Otherwise, it returns the number itself.
    /// </summary>
    /// <param name="nbr"></param>
    /// <param name="lower"></param>
    /// <param name="upper"></param>
    /// <returns></returns>
    public static int Bounderies(this int nbr, int lower, int upper)
    {
        if (nbr < lower)
        {
            return lower;
        }

        if (nbr > upper)
        {
            return upper;
        }

        return nbr;
    }

    // ************************
    /// <summary>
    /// Checks if the number is even.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsEven(this int input)
    {
        return input % 2 == 0;
    }

    // ************************
    /// <summary>
    /// Convert the number to a binary string representation, with an optional parameter to specify the lenght
    /// of (bits) to display. The output will be prefixed with "0b" to indicate that it is a binary number.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="lenght"></param>
    /// <returns></returns>
    public static string ToBinary(this int value, int lenght = 8)
    {
        string output = Convert.ToString(value, 2).PadLeft(lenght, '0');

        return "0b" + output;
    }

    // ************************
    /// <summary>
    /// Convert the number to a hexadecimal string representation, with an optional parameter to specify the lenght
    /// of (digits) to display. The output will be prefixed with "0x" to indicate that it is a hexadecimal number.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="lenght"></param>
    /// <returns></returns>
    public static string ToHex(this int value, int lenght = 4)
    {
        string output = Convert.ToString(value, 16).PadLeft(lenght, '0').ToUpper();

        return "0x" + output;
    }

    // ************************
    /// <summary>
    /// Convert the number to a octal string representation, with an optional parameter to specify the lenght
    /// of (digits) to display. The output will be prefixed with "0o" to indicate that it is an octal number.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="lenght"></param>
    /// <returns></returns>
    public static string ToOctal(this int value, int lenght = 2)
    {
        string output = Convert.ToString(value, 8).PadLeft(lenght, '0');

        return "0o" + output;
    }

    // ************************
    // From Stach Overflow
    // https://stackoverflow.com/questions/3213/convert-integers-to-written-numbers

    /// <summary>
    /// Convert the number to a written string representation. For example, 123 will be converted to
    /// "One-Hundred-Twenty-Three". The method handles numbers from 0 to 999,999,999,999 (inclusive).
    /// If the number is negative, it will be prefixed with "Negative". If the number is zero, it will
    /// return "Zero".
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static string IntegerToWritten(this int n)
    {
        if (n == 0)
        {
            return "Zero";
        }
        else if (n < 0)
        {
            return "Negative " + IntegerToWritten(-n);
        }

        return FriendlyInteger(n, "", 0);
    }

    // *****
    private static string[] ones = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

    private static string[] teens = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    private static string[] tens = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
    private static string[] thousandsGroups = { "", "-Thousand", "-Million", "-Billion" };

    private static string FriendlyInteger(int n, string leftDigits, int thousands)
    {
        if (n == 0)
        {
            return leftDigits;
        }

        string friendlyInt = leftDigits;

        if (friendlyInt.Length > 0)
        {
            friendlyInt += "-";
        }

        if (n < 10)
        {
            friendlyInt += ones[n];
        }
        else if (n < 20)
        {
            friendlyInt += teens[n - 10];
        }
        else if (n < 100)
        {
            friendlyInt += FriendlyInteger(n % 10, tens[n / 10 - 2], 0);
        }
        else if (n < 1000)
        {
            friendlyInt += FriendlyInteger(n % 100, (ones[n / 100] + "-Hundred"), 0);
        }
        else
        {
            friendlyInt += FriendlyInteger(n % 1000, FriendlyInteger(n / 1000, "", thousands + 1), 0);
            if (n % 1000 == 0)
            {
                return friendlyInt;
            }
        }

        return friendlyInt + thousandsGroups[thousands];
    }
}