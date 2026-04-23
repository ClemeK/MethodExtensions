namespace MethodExtensions
{
    internal static class ListExtensions
    {
        /// <summary>
        /// Prints the content of the list in a readable format. For example, a list containing the
        /// integers 1, 2, and 3 would be printed as "[1 2 3]".
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static string ToPrint<T>(this List<T> items) where T : IComparable<T>
        {
            string output = "";

            for (int i = 0; i < items.Count; i++)
            {
                output += " " + items[i].ToString();
            }

            return $"[{output.Trim()}]";
        }

        // **********************************
        /// <summary>
        /// Randomly selects and returns an item from the list. The selection is made using a random index,
        /// which is generated using the Random.Shared.Next method. The method ensures that the random index
        /// is within the bounds of the list, thus preventing any out-of-range errors. This extension method
        /// can be useful for scenarios where you want to randomly sample an element from a collection, such
        /// as in games, simulations, or when implementing random selection logic in your applications.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static T RandomSelect<T>(this List<T> items) where T : IComparable<T>
        {
            return items[Random.Shared.Next(0, items.Count)];
        }

        // **********************************
        /// <summary>
        /// Sorts the list in ascending order based on the natural ordering of the elements. The method uses the
        /// CompareTo method of the IComparable interface to determine the order of the elements.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        public static void Sort<T>(this List<T> items) where T : IComparable<T>
        {
            items.Sort((x, y) => x.CompareTo(y));
        }

        // **********************************
        /// <summary>
        /// Calculates the mean average of the elements in the list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static Double AverageMean<T>(this List<T> items) where T : IComparable<T>
        {
            int count = items.Count;
            double sum = 0;

            // Check if the array is empty
            if (count == 0)
            {
                throw new InvalidOperationException("List is empty.");
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
        /// Calculates the median average of the elements in the list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static Double AverageMedian<T>(this List<T> items) where T : IComparable<T>
        {
            int count = items.Count;

            // Check if the array is empty
            if (count == 0)
            {
                throw new InvalidOperationException("List is empty.");
            }

            // Ensure that the type T is convertible to a numeric type, and sorted
            T[] sortedItems = (T[])items.ToArray().Clone();
            Array.Sort(sortedItems, (x, y) => x.CompareTo(y));

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
        /// Calculates the mode average of the elements in the list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static Double AverageMode<T>(this List<T> items) where T : IComparable<T>
        {
            int count = items.Count;

            // Check if the array is empty
            if (count == 0)
            {
                throw new InvalidOperationException("List is empty.");
            }

            // Ensure that the type T is convertible to a numeric type, and sorted
            T[] sortedItems = (T[])items.ToArray().Clone();
            Array.Sort(sortedItems, (x, y) => x.CompareTo(y));

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