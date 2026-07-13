using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExtensions
{
    public static class DoubleExtensions
    {
        // ************************
        /// <summary>
        /// Checks if the number is between low and high, including low and high.
        /// </summary>
        /// <param name="nbr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public static bool Between(this double nbr, double low, double high)
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
        public static double Bounderies(this double nbr, double lower, double upper)
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

        // ************************
        /// <summary>
        /// Converts Degrees to Radians
        /// </summary>
        /// <param name="myValue"></param>
        /// <returns></returns>
        public static double ToRadians(this double myValue)
        {
            return myValue * (Math.PI / 180);
        }

        // ************************
        /// <summary>
        /// Converts Radians to Degrees
        /// </summary>
        /// <param name="myValue"></param>
        /// <returns></returns>
        public static double ToDegrees(this double myValue)
        {
            return myValue * (180 / Math.PI);
        }

        // ************************
        /// <summary>
        /// Sqare the number
        /// </summary>
        /// <param name="myValue"></param>
        /// <returns></returns>
        public static double Square(this double myValue)
        {
            return myValue * myValue;
        }

        // ************************
        /// <summary>
        /// Cube the number
        /// </summary>
        /// <param name="myValue"></param>
        /// <returns></returns>
        public static double Cube(this double myValue)
        {
            return myValue * myValue * myValue;
        }
    }
}