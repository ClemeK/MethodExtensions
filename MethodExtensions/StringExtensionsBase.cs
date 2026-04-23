public static class StringExtensionsBase
{
    /// <summary>
    /// Capitalizes the first letter of the string and makes the rest of the letters lowercase.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string Capitalize(this string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        return char.ToUpper(input[0]) + input.Substring(1).ToLower();
    }

    // ************************
    /// <summary>
    /// Capitalizes the first letter of each word in the string and makes the rest of the letters lowercase.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string TitleCase(this string input)
    {
        string output = "";
        string[] words = input.Split(' ');

        for (int i = 0; i < words.Count(); i++)
        {
            words[i] = words[i].Capitalize();
        }

        for (int i = 0; i < words.Count(); i++)
        {
            output = output + " " + words[i];
        }

        return output;
    }

    // ************************
    /// <summary>
    /// Capitalizes the first letter of each word in the string and makes the rest of the letters lowercase.
    /// The words are then concatenated together without spaces.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string PascalCase(this string input)
    {
        string output = "";

        string[] words = input.Split(' ');

        for (int i = 0; i < words.Count(); i++)
        {
            words[i] = words[i].Capitalize();
        }

        for (int i = 0; i < words.Count(); i++)
        {
            output += words[i];
        }

        return output;
    }

    // ************************
    /// <summary>
    /// Turn the string into lowercase and replace spaces with underscores.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string SnakeCase(this string input)
    {
        string output = "";

        string[] words = input.Split(' ');

        for (int i = 0; i < words.Count(); i++)
        {
            words[i] = words[i].ToLower();
        }

        for (int i = 0; i < words.Count(); i++)
        {
            if (i == 0)
            {
                output += words[i];
            }
            else
            {
                output += "_" + words[i];
            }
        }

        return output;
    }

    // ************************
    /// <summary>
    /// Converts all words in the input string to lowercase and concatenates them without spaces.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string NoCase(this string input)
    {
        string output = "";

        string[] words = input.Split(' ');

        for (int i = 0; i < words.Count(); i++)
        {
            words[i] = words[i].ToLower();
        }

        for (int i = 0; i < words.Count(); i++)
        {
            output += words[i];
        }

        return output;
    }

    // ************************
    /// <summary>
    /// Convert a hexadecimal string to an integer. The string can optionally start with "x" or "0x".
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static int HexToInt(this string value)
    {
        if (value.Substring(0, 1) == "x")
        {
            value = value.Substring(1);
        }

        int output = Int32.Parse(value, System.Globalization.NumberStyles.HexNumber);

        return output;
    }

    // ************************
    /// <summary>
    /// Reverses the characters in the string. For example, "Hello World" would become "dlroW olleH".
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string Reverse(this string value)
    {
        string output = "";

        for (int i = 0; i < value.Length; i++)
        {
            output = value[i] + output;
        }

        return output;
    }

    // ************************
    /// <summary>
    /// Converts a binary string to its integer representation.
    /// </summary>
    /// <param name="value">The binary string to convert, which may optionally start with 'b'.</param>
    /// <returns>The integer equivalent of the binary string.</returns>
    public static int BinaryToInt(this string value)
    {
        if (value.Substring(0, 1) == "b")
        {
            value = value.Substring(1);
        }

        int output = Convert.ToInt32(value, 2);

        return output;
    }

    // ************************
    /// <summary>
    /// Checks if the input string contains at least one of the characters in the "oneOf" string.
    /// The check is case-insensitive.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="oneOf"></param>
    /// <returns></returns>
    public static bool HasOneOf(this string input, string oneOf)
    {
        bool valid = false;
        string input2 = input.ToUpper();
        string oneOf2 = oneOf.ToUpper();

        for (int i = 0; i < oneOf2.Length; i++)
        {
            if (input2.Contains(oneOf2[i]))
            {
                valid = true;
                break;
            }
        }

        return valid;
    }

    // ************************
    /// <summary>
    /// Centers the input string within a field of a specified width by padding it with spaces on both sides.
    /// If the total padding required is odd, the extra space will be added to the right side of the string.
    /// For example, if the input string is "Hello" and the width is 11, the output will be "   Hello   ".
    /// If the width is less than or equal to the length of the input string, the original string will be returned
    /// without any padding.
    /// </summary>
    /// <param name="t"></param>
    /// <param name="width"></param>
    /// <returns></returns>
    public static string CenterText(this string t, int width)
    {
        string line = "";
        int fill = (width - t.Length) / 2;

        for (int i = 0; i < fill; i++)
        {
            line += " ";
        }

        line += t;

        for (int i = line.Length; i < width; i++)
        {
            line += " ";
        }

        return line;
    }

    // ************************
    /// <summary>
    /// Right-aligns the input string within a field of a specified width by padding it with spaces on the left side.
    /// </summary>
    /// <param name="t"></param>
    /// <param name="width"></param>
    /// <returns></returns>
    public static string RightText(this string t, int width)
    {
        string line = "";

        int length = t.Trim().Length;
        t = t.PadLeft(width);

        return t;
    }
}