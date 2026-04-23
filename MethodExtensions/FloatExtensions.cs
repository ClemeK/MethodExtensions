namespace MethodExtensions
{
    public static class FloatExtensions
    {
        // ************************
        /// <summary>
        /// Checks if the number is between low and high, including low and high.
        /// </summary>
        /// <param name="nbr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public static bool Between(this float nbr, float low, float high)
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
        /// Clamps the number to be between low and high, including low and high.
        /// </summary>
        /// <param name="nbr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static float Bounderies(this float nbr, float lower, float upper)
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
    }
}