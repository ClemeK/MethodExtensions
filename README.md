# MethodExtensions
This Demo program contains a group of method extension that I've written.
## Array
1. Toprint: Prints the array in a readable format.
1. Combine: Combines the string representations of the elements in the specified array i.e 1,2,3  int '123'
1. RandomSelect: Selects a random element from the array.
1. AverageMean: Calculates the average of the elements in the array.
1. AverageMedian: Calculates the median of the elements in the array.
1. AverageMode: Calculates the mode of the elements in the array.
## Bounce
1. Oscilate: The Base number will be halfed and the number will oscilate between 0 and 3 in the case of Base=6 or The differenece between Upper and Lower will be halfed and the number will oscilate between Lower and Upper
## Enum
1. GetDescription: Gets the description of an enum value if it has a DescriptionAttribute, otherwise returns null.
1. GetEnumAttribute: Gets the specified attribute of an enum value if it exists, otherwise returns null.
## Float
1. Between: Checks if the number is between low and high, including low and high.
1. Bounderies: Clamps the number to be between low and high, including low and high.
## Interger
1. Between: Checks if the number is between low and high inclusive.
1. BinaryMask: Return the result of input & ~mask, which is the bits of input with the bits of mask cleared.
1. Bounderies: Clamps the number to be between lower and upper inclusive.
1. IsEven: Checks if the number is even.
1. ToBinary: Convert the number to a binary string representation
1. ToHex: Convert the number to a hexadecimal string representation.
1. ToOct: Convert the number to a octal string representation.
1. IntegerToWritten: Convert the number to a written string representation. For example, 123 will be converted to
    /// "One-Hundred-Twenty-Three".
## List
1. ToPrint: Prints the string in a readable format.
1. RandomSelect: Selects a random element from the string.
1. Sort: Sorts the characters in the string.
1. AverageMean: Calculates the average of the characters in the string.
1. AverageMedian: Calculates the median of the characters in the string.
1. AverageMode: Calculates the mode of the characters in the string.
## Long
1. IsPrime: Checks if the number is a prime number.
1. Factorial: Calculates the factorial of the number.
1. Tetration: Calculates the tetration of the number.
## Period
1. Circ_add: Adds two numbers together and wraps the result within a specified range.
1. Circ_sub: This method subtracts one number from another and wraps the result within a specified range.
1. Circ_mult: this multiplies two numbers together and wraps the result within a specified range.
1. Circ_shortdist: This divides one number by another and wraps the result within a specified range.
1. Circ_shortdiff: This calculates the shortest distance between two numbers within a specified range.
## String
1. Capitalize: Capitalizes the first letter of each word in the string.
1. TitleCase: Converts the string to Title case.
1. PascalCase: Converts the string to Pascal case.
1. SnakeCase: Converts the string to snake case.
1. NoCase: Converts the string to no case.
1. HexToInt: Converts a hexadecimal string to an integer.
1. Reverse: Reverses the characters in the string.
1. BinaryToInt: Converts a binary string to an integer.
1. HasOneOf:  Checks if the input string contains at least one of the characters in the string.
1. CenterText: Centers the string a spcified width by padding it with spaces on both sides.
1. RightText: Aligns the string to the right within a specified width by padding it with spaces on the left.

## Console Methods
1. InputString: Prompts the user with a question and a set of valid responses, and returns the user's response.
1. InputYesNo: Uses the above method to prompt the user with a yes/no question and returns true for yes and false for no.
1. DisplayLine: Displays a Line of text on the console, breaking it into multiple lines if it exceeds a specified size.
1. BlankLine: Prints a specified number of blank lines on the console.
1. InputInt: Requests an integer input from the user within a specified range and validates the input.
1. Pause: Pauses the execution of the program until the user presses a key.
1. TimeDelay: Introduces a delay in the program execution for a specified number of second.
1. DisplayMenu1: Displays a menu and prompts the user to select one.
1. DisplayMenu2: Displays a menu with a list of options and prompts the user to select one.
1. SimpleHeading: Displays a simple heading on the console.

1. DrawLine: Draws a line on the console, of a specified character and lenght.
1. MakeString: Creates a string with a specified character repeated a specified number of times.
1. FlushConsole: Clears the console buffer.