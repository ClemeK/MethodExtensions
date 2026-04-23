namespace MethodExtensions
{
    public static class Bounce
    {
        /// <summary>
        /// The Base number will be halfed and the number will oscilate between 0 and 3
        /// in the case of Base=6
        /// </summary>
        /// <param name="TimeDiff">change in time</param>
        /// <param name="Base">The total difference</param>
        /// <returns></returns>
        public static int Oscilate(int TimeDiff, int Base)
        {
            int output = Math.Abs(TimeDiff - ((TimeDiff / Base) * Base) - (Base / 2));

            return output;
        }

        /// <summary>
        /// The differenece between Upper and Lower will be halfed and the number will
        /// oscilate between Lower and Upper
        /// </summary>
        /// <param name="TimeDiff"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static int Oscilate(int TimeDiff, int lower, int upper)
        {
            int Base = upper - lower;

            int output = Math.Abs(TimeDiff - ((TimeDiff / Base) * Base) - (Base / 2));

            return lower + output;
        }
    }
}