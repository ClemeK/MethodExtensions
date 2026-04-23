namespace MethodExtensions
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Prints the array in a readable format.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static string ToPrint<T>(this T[] items) where T : IComparable<T>
        {
            string output = "";

            for (int i = 0; i < items.Length; i++)
            {
                output += " " + items[i].ToString();
            }

            return "[" + output.Trim() + "]";
        }

        // **********************************
        /// <summary>
        /// Combines the string representations of the elements in the specified array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns>A single string that contains the combined values of the array elements.
        /// </returns>
        public static string Combine<T>(this T[] items) where T : IComparable<T>
        {
            string output = "";

            for (int i = 0; i < items.Length; i++)
            {
                output += items[i].ToString().Trim();
            }

            return output.Trim();
        }

        // **********************************
        /// <summary>
        /// Select a random item from the array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static T RandomSelect<T>(this T[] items) where T : IComparable<T>
        {
            return items[Random.Shared.Next(0, items.Length)];
        }

        // **********************************
        /// <summary>
        /// Calculates the average of the array using the mean method.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static Double AverageMean<T>(this T[] items) where T : IComparable<T>
        {
            int count = items.Length;
            double sum = 0;

            // Check if the array is empty
            if (count == 0)
            {
                throw new InvalidOperationException("Array is empty.");
            }

            // Ensure that the type T is convertible to a numeric type
            foreach (T item in items)
            {
                if (item is not IConvertible)
                {
                    throw new InvalidOperationException("Type must be convertible to a numeric type.");
                }

                // Convert the item to double and add it to the sum
                sum += Convert.ToDouble(item);
            }

            return sum / count;
        }

        // **********************************
        /// <summary>
        /// Calculates the average of the array using the median method.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static Double AverageMedian<T>(this T[] items) where T : IComparable<T>
        {
            int count = items.Length;

            // Check if the array is empty
            if (count == 0)
            {
                throw new InvalidOperationException("Array is empty.");
            }

            // Ensure that the type T is convertible to a numeric type, and sorted
            T[] sortedItems = (T[])items.Clone();
            Array.Sort(sortedItems);

            // Calculate the median
            if (count % 2 == 1)
            {
                return Convert.ToDouble(sortedItems[count / 2]);
            }
            else
            {
                double mid1 = Convert.ToDouble(sortedItems[(count / 2) - 1]);
                double mid2 = Convert.ToDouble(sortedItems[count / 2]);
                return (mid1 + mid2) / 2;
            }
        }

        // **********************************
        /// <summary>
        /// Calculates the average of the array using the mode method.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static Double AverageMode<T>(this T[] items) where T : IComparable<T>
        {
            int count = items.Length;

            // Check if the array is empty
            if (count == 0)
            {
                throw new InvalidOperationException("Array is empty.");
            }

            // Ensure that the type T is convertible to a numeric type, and sorted
            T[] sortedItems = (T[])items.Clone();
            Array.Sort(sortedItems);

            // Calculate the frequency of each item
            Dictionary<T, int> frequency = new Dictionary<T, int>();

            foreach (T item in sortedItems)
            {
                if (frequency.ContainsKey(item))
                {
                    frequency[item]++;
                }
                else
                {
                    frequency[item] = 1;
                }
            }

            // Find the maximum frequency
            int maxFrequency = frequency.Values.Max();
            var modes = frequency.Where(pair => pair.Value == maxFrequency).Select(pair => pair.Key).ToArray();

            if (modes.Length == 1)
            {
                return Convert.ToDouble(modes[0]);
            }
            else
            {
                double sum = 0;
                foreach (var mode in modes)
                {
                    sum += Convert.ToDouble(mode);
                }
                return sum / modes.Length;
            }
        }
    }
}