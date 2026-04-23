using static System.Console;

namespace MethodExtensions
{
    /// <summary>
    /// Some methiod I developed for screen hadleing before I came across AnsiConsole and
    /// I still use them in some places. They can essally be change to use AnsiConsole if need be.
    /// </summary>
    internal static class Konsole
    {
        /// <summary>
        /// Prompts the user with a yes or no question and returns the response.
        /// </summary>
        /// <param name="questionText">The question to display to the user.</param>
        /// <returns>A string containing either 'Y' or 'N' based on the user's input.</returns>
        public static string InputYesNo(string questionText)
        {
            string output;

            output = InputString(questionText, "YN");

            return output;
        }

        // *****************************************
        /// <summary>
        /// Prompts the user with a question and a set of valid responses, and returns the user's response.
        /// </summary>
        /// <param name="questionText">The question to display to the user.</param>
        /// <param name="responses">A string containing the valid responses. Use '*' to allow any input.</param>
        /// <returns>A string containing the user's response.</returns>
        public static string InputString(string questionText, string responses)
        {
            responses = responses.Trim();
            bool valid = false;
            int loc = 888;

            if (responses != "*")
            {
                Console.WriteLine($"{questionText} ({responses})? ");

                do
                {
                    FlushConsole();
                    string key = "";

                    do
                    {
                        key = Console.ReadLine();
                    } while (key == "");

                    if (key.HasOneOf(responses))
                    {
                        loc = responses.IndexOf(key);
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                        Console.WriteLine("Invalid input!");

                        Console.WriteLine($"{questionText} ({responses})? ");
                    }
                } while (!valid);

                return responses.Substring(loc, 1);
            }
            else
            {
                Console.WriteLine($"{questionText}? ");

                FlushConsole();
                string key = "";

                do
                {
                    key = Console.ReadLine();
                } while (key.Length < 1);

                return key;
            }
        }

        // *****************************************
        /// <summary>
        /// Displays a Line of text on the console, breaking it into multiple lines if it exceeds a specified size.
        /// </summary>
        /// <param name="size">The maximum number of characters per line.</param>
        /// <param name="text">The text to display.</param>
        /// <param name="withCR">Whether to append a carriage return at the end of each line.</param>
        public static void DisplayLine(int size, string text, Justify justify = Justify.Left, bool withCR = true)
        {
            string textToPrint = "";
            string remaining = "";

            if (text.Length < size)
            {
                if (withCR)
                {
                    if (justify == Justify.Left)
                    {
                        Console.Write($"{text}\n");
                    }
                    else if (justify == Justify.Center)
                    {
                        Console.Write($"{text.CenterText(size)}\n");
                    }
                    else if (justify == Justify.Right)
                    {
                        Console.Write($"{text.RightText(size)}\n");
                    }
                }
                else
                {
                    if (justify == Justify.Left)
                    {
                        Console.Write($"{text}");
                    }
                    else if (justify == Justify.Center)
                    {
                        Console.Write($"{text.CenterText(size)}");
                    }
                    else if (justify == Justify.Right)
                    {
                        Console.Write($"{text.RightText(size)}");
                    }
                }
            }
            else
            {
                do
                {
                    if (text.Length > size)
                    {
                        textToPrint = "";
                        remaining = "";

                        string[] words = text.Split(" ");
                        int ptr = 0;

                        do
                        {
                            textToPrint = textToPrint + words[ptr] + " ";
                            ptr++;
                        } while ((textToPrint.Length + words[ptr].Length) < size);

                        for (int i = ptr; i < words.Count(); i++)
                        {
                            remaining = remaining + words[i] + " ";
                        }
                    }
                    else
                    {
                        textToPrint = text;
                        remaining = "";
                    }

                    if (withCR)
                    {
                        if (justify == Justify.Left)
                        {
                            Console.Write($"{textToPrint}\n");
                        }
                        else if (justify == Justify.Center)
                        {
                            Console.Write($"{textToPrint.CenterText(size)}\n");
                        }
                        else if (justify == Justify.Right)
                        {
                            Console.Write($"{textToPrint.RightText(size)}\n");
                        }
                    }
                    else
                    {
                        if (justify == Justify.Left)
                        {
                            Console.Write($"{textToPrint}");
                        }
                        else if (justify == Justify.Center)
                        {
                            Console.Write($"{textToPrint.CenterText(size)}");
                        }
                        else if (justify == Justify.Right)
                        {
                            Console.Write($"{textToPrint.RightText(size)}");
                        }
                    }

                    text = remaining;
                } while (remaining != "");
            }
        }

        // *****************************************
        /// <summary>
        /// Print a set number of Blank Line on the Console
        /// </summary>
        /// <param name="count"></param>
        public static void BlankLine(int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine();
            }
        }

        // *****************************************
        /// <summary>
        /// Requests an integer input from the user within a specified range and validates the input.
        /// </summary>
        /// <param name="questionText"></param>
        /// <param name="Lower"></param>
        /// <param name="Higher"></param>
        /// <returns></returns>
        public static int InputInt(string questionText, int Lower, int Higher)
        {
            DisplayLine(120, questionText, false);

            bool valid = false;
            int nbrAns = 0;

            do
            {
                FlushConsole();

                string key = ReadLine();

                if (key != "")
                {
                    nbrAns = int.Parse(key);

                    valid = nbrAns.Between(Lower, Higher);
                }
                else
                {
                    valid = false;
                    DisplayLine(120, "Invalid input!");

                    DisplayLine(120, questionText, false);
                }
            } while (!valid);

            return nbrAns;
        }

        // *****************************************
        /// <summary>
        /// Pauses the console and prompts the user to press any key to continue, with an optional custom message.
        /// </summary>
        /// <param name="text"></param>
        public static void Pause(string text = "\nPress any key ...")
        {
            FlushConsole();

            DisplayLine(120, $"\n{text}");

            Read();

            FlushConsole();
        }

        // *****************************************
        /// <summary>
        /// Delays the execution of the program for a specified number of seconds,
        /// displaying a dot for each second that passes.
        /// </summary>
        /// <param name="seconds"></param>
        public static void TimeDelay(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Thread.Sleep(1000);
                Console.Write(". ");
            }

            BlankLine();
        }

        // *****************************************
        /// <summary>
        /// Displays a numbered menu of options with a specified width.
        /// </summary>
        /// <param name="size">The width of the menu display.</param>
        /// <param name="option">The menu options to display.</param>
        public static void DisplayMenu1(string[] option)
        {
            for (int i = 0; i < option.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {option[i]}");
            }

            BlankLine();
        }

        // *****************************************
        /// <summary>
        /// Displays a menu of options with custom keys for each option.
        /// </summary>
        /// <param name="option">The menu options to display.</param>
        /// <param name="optionKey">The keys corresponding to each menu option.</param>
        public static void DisplayMenu2(string[] option, string[] optionKey)
        {
            for (int i = 0; i < option.Length; i++)
            {
                Console.WriteLine($"{optionKey[i]}. {option[i]}");
            }

            BlankLine();
        }

        // *****************************************
        /// <summary>
        /// Justification options for text alignment in console output.
        /// </summary>
        public enum Justify
        {
            Left,
            Center,
            Right
        }

        // *****************************************
        /// <summary>
        ///  Simple Heading
        /// </summary>
        /// <param name="width"></param>
        /// <param name="c"></param>
        public static void SimpleHeading(int width, char c, string Headingtext)
        {
            Console.Clear();

            Konsole.DrawLine(width, c);
            Konsole.DisplayLine(width, Headingtext.CenterText(80));
            Konsole.DrawLine(width, c);
        }

        // *****************************************
        // The methods were Private as thy were used in some of the above methods but I since changed them to Public.
        // *****************************************

        /// <summary>
        /// Draws a line of a specified character and width.
        /// </summary>
        /// <param name="c">The character to use for the line.</param>
        /// <param name="width">The width of the line.</param>
        /// <returns>A string representing the line.</returns>
        public static void DrawLine(int width, char c)
        {
            Console.WriteLine(MakeString(width, c));
        }

        // *****************************************
        /// <summary>
        /// Makes a string consisting of a specified character repeated a certain number of times.
        /// </summary>
        /// <param name="c">The character to repeat.</param>
        /// <param name="width">The number of times to repeat the character.</param>
        /// <returns>A string consisting of the repeated character.</returns>
        public static string MakeString(int width, char c)
        {
            string line = "";

            for (int i = 0; i < width; i++)
            {
                line += c;
            }

            return line;
        }

        // *****************************************
        /// <summary>
        /// Flushes the console input stream by reading and discarding any available input until
        /// there is no more input to read.
        /// </summary>
        private static void FlushConsole()
        {
            // Flush the input stream
            while (KeyAvailable) ReadKey(false);
        }
    }
}