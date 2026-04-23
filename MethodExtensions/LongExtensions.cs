public static class LongExtensions
{
    // ************************
    /// <summary>
    /// Checks if a number is prime. A prime number is a natural number greater than 1 that cannot be formed
    /// by multiplying two smaller natural numbers. The first few prime numbers are 2, 3, 5, 7, 11, and so on.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsPrime(this long number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }

    // ************************
    /// <summary>
    /// Calculates the factorial of a number. The factorial of a non-negative integer n is the product of
    /// all positive integers less than or equal to n.
    /// For example, the factorial of 5 is 5 * 4 * 3 * 2 * 1 = 120.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static long Factorial(this long number)
    {
        long output = 0;

        if (number <= 1)
        {
            output = 1;
        }
        else
        {
            output = number;
            do
            {
                number--;
                output *= number;
            } while (number != 1);
        }

        return output;
    }

    // ************************
    /// <summary>
    /// Performs a Tetration on a long input with a given height. Tetration is an operation that
    /// iterates exponentiation. For example, if the input is 2 and the height is 3, the result
    /// will be 2^(2^2) = 16. If the height is 0, it returns 0. Note that Tetration grows very
    /// rapidly, so be cautious when using large inputs or heights, as it may result in overflow
    /// or long computation times.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static long Tetration(this long input, int height)
    {
        if (height == 0) return 0;

        long Output = 0;

        long[] inputs = new long[height+1];

        for (int i = 0; i < height+1; i++)
        {
            inputs[i] = input;
        }

        for (int i = height ; i > 0; i--)
        {
            Output = (long)Math.Pow(inputs[i], inputs[i - 1]);
            inputs[i - 1] = Output;
        }

        return Output;
    }
}