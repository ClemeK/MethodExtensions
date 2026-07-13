namespace MethodExtensions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool exit = true;

            do
            {
                Console.Clear();

                Konsole.SimpleHeading(80, '*', "Method Extensions");

                string[] menuOptions = {
            "Interger Extension" ,
            "Floating Point Extension",
            "String Extension" ,
            "Long Extension",
            "Priodic Calculations" ,
            "Arrays" ,
            "Lists" ,
            "Bounce" ,
            "eNums" ,
            "Doubles" ,
            "Quit"};

                string[] menuKey = {
            "Ii" ,
            "Ff" ,
            "Ss" ,
            "Ll" ,
            "Pp" ,
            "Aa" ,
            "Tt" ,
            "Bb" ,
            "Ee" ,
            "Dd" ,
            "Qq"};

                Konsole.DisplayMenu2(menuOptions, menuKey);

                string choose = Konsole.InputString("Select a menu option", menuKey.Combine());

                switch (choose.ToUpper())
                {
                    case "I":
                        IntMethords();
                        break;

                    case "F":
                        FloatMethodes();
                        break;

                    case "S":
                        StringMethords();
                        break;

                    case "L":
                        LongMethods();
                        break;

                    case "P":
                        PeriodicMethods();
                        break;

                    case "A":
                        ArrayMethods();
                        break;

                    case "T":
                        ListMethods();
                        break;

                    case "B":
                        BounceMethods();
                        break;

                    case "E":
                        EnumsMethods();
                        break;

                    case "D":
                        DoublesMethods();
                        break;

                    case "Q":
                        exit = false;
                        Console.WriteLine("\n\nGoodbye ...");
                        break;
                }
            } while (exit);
        }

        // ========================================================================
        private static void ArrayMethods()
        {
            Konsole.SimpleHeading(80, '*', "Arrays");

            // ************************
            // Print an Array
            Console.WriteLine("\nPrint an Array");

            int[] IntArray = new int[9] { 1, 5, 9, 8, 4, 6, 2, 3, 7 };
            Console.WriteLine($"Array IntArray contains - {IntArray.ToPrint()}");
            Console.WriteLine($"Randon selection - {IntArray.RandomSelect()}");
            Console.WriteLine($"Mean average - {IntArray.AverageMean().ToString("F2")}");
            Console.WriteLine($"Median average - {IntArray.AverageMedian().ToString("F2")}");
            Console.WriteLine($"Mode average - {IntArray.AverageMode().ToString("F2")}");
            Console.WriteLine();

            float[] FloatArray = new float[9] { 1.1f, 5.5f, 9.9f, 8.4f, 4.8f, 6.6f, 2.7f, 3.2f, 7.3f };
            Console.WriteLine($"Array FloatArray contains - {FloatArray.ToPrint()}");
            Console.WriteLine($"Randon selection - {FloatArray.RandomSelect()}");
            Console.WriteLine($"Mean average - {FloatArray.AverageMean().ToString("F2")}");
            Console.WriteLine($"Median average - {FloatArray.AverageMedian().ToString("F2")}");
            Console.WriteLine($"Mode average - {FloatArray.AverageMode().ToString("F2")}");
            Console.WriteLine();

            string[] StringArray = new string[9] { "A", "B", "C", "D", "E", "F", "G", "H", "I" };
            Console.WriteLine($"Array StringArray contains - {StringArray.ToPrint()}");
            Console.WriteLine($"Randon selection - {StringArray.RandomSelect()}");

            // ************************************************
            Konsole.Pause();
        }

        // ========================
        private static void BounceMethods()
        {
            Konsole.SimpleHeading(80, '*', "Bounce");

            // ************************
            // Bounce
            Console.WriteLine("\nOscilate around a number");

            int osc = 6;

            for (int i = 0; i < 20; i++)
            {
                // this will oscilate bewteen 0 and 3
                Console.Write($"{Bounce.Oscilate(i, osc)}, ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < 20; i++)
            {
                // This will oscilate between 5 and 8
                Console.Write($"{Bounce.Oscilate(i, 5, 11)}, ");
            }

            // ************************************************
            Konsole.Pause();
        }

        // ========================
        private static void DoublesMethods()
        {
            Konsole.SimpleHeading(80, '*', "Double");

            // ************************
            // Double
            // ************************
            // Check number is between two other numbers
            Console.WriteLine("\nCheck number is between two other numbers");
            double nbr1 = 5.01d;
            double nbr2 = 10.5d;
            double nbr3 = 7.15d;
            Console.WriteLine($"Is {nbr3} between {nbr1} and {nbr2} answer is {nbr3.Between(nbr1, nbr2)}");
            Console.WriteLine($"Is {nbr1} between {nbr2} and {nbr3} answer is {nbr1.Between(nbr2, nbr3)}");
            Console.WriteLine($"Is {nbr2} between {nbr1} and {nbr3} answer is {nbr2.Between(nbr1, nbr3)}");

            // ************************
            // Check number is KEPT between two other numbers
            Console.WriteLine("\nCheck number is KEPT between two other numbers (3.5, 7.5)");

            double temp = 0;
            Console.Write($"i = ");
            for (double i = 0; i < 9; i++)
            {
                temp = i.Bounderies(3.5d, 7.5d);
                Console.Write($"{temp}, ");
            }

            // ************************
            // Silly Squared and Cubed numbers
            Console.WriteLine("\n\nSquared and Cubed numbers");

            double dtemp = 5.0d;
            Console.WriteLine($"The square of {dtemp} is {dtemp.Square()}");
            Console.WriteLine($"The cube of {dtemp} is {dtemp.Cube()}");

            // ************************
            // Degrees and Radians
            Console.WriteLine("\nConverting between degrees and Radian");
            double degree = 47.5d;
            Console.WriteLine($"convert {degree}degrees to {degree.ToRadians().ToString("F5")} radians");
            double radian = 0.12345d;
            Console.WriteLine($"convert {radian} radians {radian.ToDegrees().ToString("F5")} degrees");

            // ************************************************
            Konsole.Pause();
        }

        // ========================
        private static void EnumsMethods()
        {
            Konsole.SimpleHeading(80, '*', "eNums");

            // ************************
            // eNums

            Console.WriteLine($"The name for 'Antigua_and_Barbuda' is {enmCountry.Antigua_and_Barbuda}");
            Console.WriteLine($"The numeical for 'Antigua_and_Barbuda' is {(int)enmCountry.Antigua_and_Barbuda}");
            Console.WriteLine($"The desciption for 'Antigua_and_Barbuda' is {EnumExtensions.GetDescription(enmCountry.Antigua_and_Barbuda)}");
            Console.WriteLine($"The 5th country is {(enmCountry)5}");

            // ************************************************
            Konsole.Pause();
        }

        // ========================
        private static void FloatMethodes()
        {
            Konsole.SimpleHeading(80, '*', "Floating Point Extension");

            // ************************
            // Check number is between two other numbers
            Console.WriteLine("\nCheck number is between two other numbers");
            float nbr1 = 5.01f;
            float nbr2 = 10.5f;
            float nbr3 = 7.15f;
            Console.WriteLine($"Is {nbr3} between {nbr1} and {nbr2} answer is {nbr3.Between(nbr1, nbr2)}");
            Console.WriteLine($"Is {nbr1} between {nbr2} and {nbr3} answer is {nbr1.Between(nbr2, nbr3)}");
            Console.WriteLine($"Is {nbr2} between {nbr1} and {nbr3} answer is {nbr2.Between(nbr1, nbr3)}");

            // ************************
            // Check number is KEPT between two other numbers
            Console.WriteLine("\nCheck number is KEPT between two other numbers (3.5, 7.5)");

            float temp = 0;
            Console.Write($"i = ");
            for (float i = 0; i < 9; i++)
            {
                temp = i.Bounderies(3.5f, 7.5f);
                Console.Write($"{temp}, ");
            }

            // ************************
            // Silly Squared and Cubed numbers
            Console.WriteLine("\n\nSquared and Cubed numbers");

            float dtemp = 3.0f;
            Console.WriteLine($"The square of {dtemp} is {dtemp.Square()}");
            Console.WriteLine($"The cube of {dtemp} is {dtemp.Cube()}");

            // ************************
            // Degrees and Radians
            Console.WriteLine("\nConverting between degrees and Radian");
            float degree = 47.5f;
            Console.WriteLine($"convert {degree}degrees to {degree.ToRadians().ToString("F5")} radians");
            float radian = 0.12345f;
            Console.WriteLine($"convert {radian} radians {radian.ToDegrees().ToString("F5")} degrees");

            // ************************************************
            Konsole.Pause();
        }

        // ========================
        private static void IntMethords()
        {
            Konsole.SimpleHeading(80, '*', "Interger Extension");

            // ************************
            // Average a set of numbers.
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("\bAverage a set of numbers.");
            Console.WriteLine($"{numbers.Average()}");

            // ************************
            // Check if a number is Even or Odd.
            Console.WriteLine("\nCheck if a number is Even or Odd.");
            foreach (var item in numbers)
            {
                if (item.IsEven())
                {
                    Console.WriteLine($"{item} is even");
                }
                else
                {
                    Console.WriteLine($"{item} is odd");
                }
            }

            // ************************
            // Convert Int to Hex
            Console.WriteLine("\nConvert Int to Hex");
            int nbr = 10;
            Console.WriteLine($"{nbr} is {nbr.ToHex()}");
            nbr = 20;
            Console.WriteLine($"{nbr} is {nbr.ToHex()}");
            nbr = 4589;
            Console.WriteLine($"{nbr} is {nbr.ToHex()}");

            // ************************
            // Convert Int to Octal
            Console.WriteLine("\nConvert Int to Octal");
            nbr = 12;
            Console.WriteLine($"{nbr} is {nbr.ToOctal()}");
            nbr = 24;
            Console.WriteLine($"{nbr} is {nbr.ToOctal()}");

            // ************************
            // Convert Int to Binary
            Console.WriteLine("\nConvert Int to Binary");
            nbr = 5;
            Console.WriteLine($"{nbr} is {nbr.ToBinary()}");
            nbr = 20;
            Console.WriteLine($"{nbr} is {nbr.ToBinary()}");

            // ************************
            // BinaryMask
            Console.WriteLine("\nBinary mask(using the 20 and masking out 5)");
            int result = nbr.BinaryMask(5);
            Console.WriteLine($"{result} is {result.ToBinary()}");

            // ************************
            // Is a Prime number
            Console.WriteLine("\nIs a Prime number");
            long lgnbr = 5;
            Console.WriteLine($"{lgnbr} is {lgnbr.IsPrime()}");
            lgnbr = 10;
            Console.WriteLine($"{lgnbr} is {lgnbr.IsPrime()}");

            // ************************
            // Factorial of the number
            Console.WriteLine("\nFactorial of the number");
            lgnbr = 5;
            Console.WriteLine($"{lgnbr} is {lgnbr.Factorial()}");
            lgnbr = 16;
            Console.WriteLine($"{lgnbr} is {lgnbr.Factorial().ToString("#,##0")}");

            // ************************
            // Check number is between two other numbers
            Console.WriteLine("\nCheck number is between two other numbers");
            int nbr1 = 5;
            int nbr2 = 10;
            int nbr3 = 7;
            Console.WriteLine($"Is {nbr3} between {nbr1} and {nbr2} answer is {nbr3.Between(nbr1, nbr2)}");
            Console.WriteLine($"Is {nbr1} between {nbr2} and {nbr3} answer is {nbr1.Between(nbr2, nbr3)}");
            Console.WriteLine($"Is {nbr2} between {nbr1} and {nbr3} answer is {nbr2.Between(nbr1, nbr3)}");

            // ************************
            // Check number is KEPT between two other numbers
            Console.WriteLine("\nCheck number is KEPT between two other numbers (5, 12)");

            int temp1 = 0;
            Console.Write($"i = ");
            for (int i = 0; i < 15; i++)
            {
                temp1 = i.Bounderies(5, 12);
                Console.Write($"{temp1}, ");
            }

            // ************************
            // Silly Squared and Cubed numbers
            Console.WriteLine("\n\nSquared and Cubed numbers");

            int itemp = 3;
            Console.WriteLine($"The square of {itemp} is {itemp.Square()}");
            Console.WriteLine($"The cube of {itemp} is {itemp.Cube()}");

            // ************************
            // Print number in human form
            Console.WriteLine("\n\nHuman readable numbers");

            int temp2 = Random.Shared.Next(1, 100);
            Console.WriteLine($"Random number {temp2} is {temp2.IntegerToWritten()}");
            temp2 = Random.Shared.Next(100, 1000);
            Console.WriteLine($"Random number {temp2} is {temp2.IntegerToWritten()}");
            temp2 = Random.Shared.Next(1000, 10000);
            Console.WriteLine($"Random number {temp2} is {temp2.IntegerToWritten()}");

            // ************************************************
            Konsole.Pause();
        }

        // ========================
        private static void ListMethods()
        {
            Konsole.SimpleHeading(80, '*', "Lists");

            // ************************
            // Print a List
            Console.WriteLine("\nPrint a List");

            List<int> IntList = new() { 1, 5, 9, 8, 4, 6, 2, 3, 7 };
            Console.WriteLine($"List IntListy contains - {IntList.ToPrint()}");
            Console.WriteLine($"Randon selection - {IntList.RandomSelect()}");
            Console.WriteLine($"Mean average - {IntList.AverageMean().ToString("F2")}");
            Console.WriteLine($"Median average - {IntList.AverageMedian().ToString("F2")}");
            Console.WriteLine($"Mode average - {IntList.AverageMode().ToString("F2")}");
            ListExtensions.Sort(IntList);
            Console.WriteLine($"List Sorted IntList contains - {IntList.ToPrint()}\n");
            Console.WriteLine();

            List<float> FloatList = new() { 1.1f, 5.5f, 9.9f, 8.4f, 4.8f, 6.6f, 2.7f, 3.2f, 7.3f };
            Console.WriteLine($"List FloatList contains - {FloatList.ToPrint()}");
            Console.WriteLine($"Randon selection - {FloatList.RandomSelect()}\n");
            Console.WriteLine($"Mean average - {FloatList.AverageMean().ToString("F2")}");
            Console.WriteLine($"Median average - {FloatList.AverageMedian().ToString("F2")}");
            Console.WriteLine($"Mode average - {FloatList.AverageMode().ToString("F2")}");

            ListExtensions.Sort(FloatList);
            Console.WriteLine($"List Sorted FloatList contains - {FloatList.ToPrint()}\n");
            Console.WriteLine();

            List<string> StringList = new() { "A", "B", "C", "D", "E", "F", "G", "H", "I" };
            Console.WriteLine($"List StringList contains - {StringList.ToPrint()}");
            Console.WriteLine($"Randon selection - {StringList.RandomSelect()}");

            // ************************************************
            Konsole.Pause();
        }

        // ========================
        private static void LongMethods()
        {
            Konsole.SimpleHeading(80, '*', "Long Calculations");

            // Check if a number is Even or Odd.
            Console.WriteLine("\nCheck if a number is Even or Odd.");
            for (long item = 1; item < 50; item++)
            {
                if (item.IsPrime())
                {
                    Console.WriteLine($"{item} is a Prime");
                }
            }

            // ************************
            // Factorial of the number
            Console.WriteLine("\nFactorial of the number");
            long lgnbr = 15;
            Console.WriteLine($"{lgnbr} is {lgnbr.Factorial()}");
            lgnbr = 21;
            Console.WriteLine($"{lgnbr} is {lgnbr.Factorial().ToString("#,##0")}");

            // ************************
            // Tetration of the number
            Console.WriteLine("\nTetration of the number");
            lgnbr = 2;
            int height = 4;
            Console.WriteLine($"{lgnbr} Tetration to the height of {height} is ");
            Console.WriteLine($"{lgnbr.Tetration(height).ToString("#,##0")}");

            // ************************************************
            Konsole.Pause();
        }

        // ========================
        private static void PeriodicMethods()
        {
            Konsole.SimpleHeading(80, '*', "Priodic Calculations");

            int a1 = 20;
            int b1 = 340;

            int c1 = Periodic.Circ_add(a1, b1);
            Console.WriteLine($"a:{a1} + b:{b1} = c:{c1}");
            Console.WriteLine($"{Periodic.Circ_shortdiff(a1, b1)}");

            float a2 = 90.5f;
            float b2 = 295.6f;

            float c2 = Periodic.Circ_add(a2, b2);
            Console.WriteLine($"a:{a2} + b:{b2} = c:{c2}");
            Console.WriteLine($"{Periodic.Circ_shortdiff(a2, b2)}");

            // ************************************************
            Konsole.Pause();
        }

        // ========================
        private static void StringMethords()
        {
            Konsole.SimpleHeading(80, '*', "String Extension");

            // ************************
            // Justification
            Console.WriteLine("\nJustification of text");
            Konsole.DrawLine(80, '-');
            Konsole.DisplayLine(80, "Left Justify");
            Console.WriteLine("Right Justify".RightText(80));
            Console.WriteLine("Center Justify".CenterText(80));

            // ************************
            // Capitalise a Word.
            String name = "kelvin";
            Console.WriteLine("\nCapitalise a Word.");
            Console.WriteLine($"{name.Capitalize()}");

            // ************************
            // Title Case
            Console.WriteLine("\nTitle Case");
            string sentance = "this is the winter of our discontent.";
            Console.WriteLine($"{sentance} = {sentance.TitleCase()}");

            // ************************
            // Pascal Case
            Console.WriteLine("\nPascal Case");
            Console.WriteLine($"{sentance} = {sentance.PascalCase()}");

            // ************************
            // Snake Case
            Console.WriteLine("\nSnake Case");
            Console.WriteLine($"{sentance} = {sentance.SnakeCase()}");

            // ************************
            // No Case
            Console.WriteLine("\nNo Case");
            Console.WriteLine($"{sentance} = {sentance.NoCase()}");

            // ************************
            // Reverse Text
            Console.WriteLine("\nReverse Text");
            Console.WriteLine($"{sentance} = {sentance.Reverse()}");

            // ************************
            // Hex to Int
            string hexNumber = "xFF";
            Console.WriteLine("\nHex to Int");
            Console.WriteLine($"{hexNumber} = {hexNumber.HexToInt()}");
            hexNumber = "x1F";
            Console.WriteLine($"{hexNumber} = {hexNumber.HexToInt()}");

            // ************************
            // Binary to Int
            Console.WriteLine("\nHex to Int");
            string BinaryNumber = "b11";
            Console.WriteLine($"{BinaryNumber} = {BinaryNumber.BinaryToInt()}");
            BinaryNumber = "b1111";
            Console.WriteLine($"{BinaryNumber} = {BinaryNumber.BinaryToInt()}");
            BinaryNumber = "b10101010";
            Console.WriteLine($"{BinaryNumber} = {BinaryNumber.BinaryToInt()}");

            // ************************
            // Has One Of
            Console.WriteLine("\nHas One Of");
            string vowels = "AEIOU";
            string word = "Friends";
            Console.WriteLine($"Is there one of these ({vowels}) in the word '{word}' = {word.HasOneOf(vowels.ToString())}");
            word = "why";
            Console.WriteLine($"Is there one of these ({vowels}) in the word '{word}' = {word.HasOneOf(vowels.ToString())}");

            sentance = "The Quick Brown Fox Jumped Over the Lazy Cow";
            Console.WriteLine($"Center the text: *{sentance}* in a 100 char string");
            Console.WriteLine(sentance.CenterText(100));

            // ************************************************
            Konsole.Pause();
        }

        // ========================
    }
}