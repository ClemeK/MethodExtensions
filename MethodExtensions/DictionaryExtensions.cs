namespace MethodExtensions
{
    public static class DictionaryExtensions
    {
        public static string ToPrint<TKey, TValue>(this Dictionary<TKey, TValue> dict)
        {
            string output = string.Empty;

            foreach (var i in dict)
            {
                output = output + $"[{i.Key}: {i.Value}]\n";
            }

            return output;
        }

        // ************************
    }
}