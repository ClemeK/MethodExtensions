namespace MethodExtensions
{
    public static class Periodic
    {
        /// <summary>
        /// Adds two numbers together and wraps the result within a specified range. If the result exceeds
        /// the maximum value, it wraps around to the minimum value, and if it goes below the minimum value,
        /// it wraps around to the maximum value. This is particularly useful for operations involving angles
        /// (e.g., degrees or radians) where values should stay within a certain range (e.g., 0 to 360 degrees).
        /// The method can be used for both integer and floating-point numbers.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <param name="rmin"></param>
        /// <param name="rmax"></param>
        /// <returns></returns>
        public static int Circ_add(int lhs, int rhs, int rmin = 0, int rmax = 360)
        {
            int result = lhs + rhs;
            int range = rmax - rmin;

            while (result >= rmax)
            {
                result -= range;
            }

            while (result < rmin)
            {
                result += range;
            }

            return result;
        }

        // **********************************
        public static float Circ_add(float lhs, float rhs, float rmin = 0f, float rmax = 360f)
        {
            float result = lhs + rhs;
            float range = rmax - rmin;

            while (result >= rmax)
            {
                result -= range;
            }

            while (result < rmin)
            {
                result += range;
            }

            return result;
        }

        // **********************************
        /// <summary>
        /// This method subtracts one number from another and wraps the result within a specified range,
        /// similar to the Circ_add method. If the result exceeds the maximum value, it wraps around to the
        /// minimum value, and if it goes below the minimum value, it wraps around to the maximum value.
        /// This is useful for operations involving angles or any periodic values where you want to ensure
        /// that the result stays within a certain range. The method can be used for both integer and floating-point
        /// numbers.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <param name="rmin"></param>
        /// <param name="rmax"></param>
        /// <returns></returns>
        public static int Circ_sub(int lhs, int rhs, int rmin = 0, int rmax = 360)
        {
            int result = lhs - rhs;
            int range = rmax - rmin;

            while (result >= rmax)
            {
                result -= range;
            }

            while (result < rmin)
            {
                result += range;
            }

            return result;
        }

        // **********************************
        public static float Circ_sub(float lhs, float rhs, float rmin = 0f, float rmax = 360f)
        {
            float result = lhs - rhs;
            float range = rmax - rmin;

            while (result >= rmax)
            {
                result -= range;
            }

            while (result < rmin)
            {
                result += range;
            }

            return result;
        }

        // **********************************
        /// <summary>
        /// this multiplies two numbers together and wraps the result within a specified range, similar to the
        /// Circ_add and Circ_sub methods. If the result exceeds the maximum value, it wraps around to the minimum
        /// value, and if it goes below the minimum value, it wraps around to the maximum value. This is useful for
        /// operations involving angles or any periodic values where you want to ensure that the result stays within
        /// a certain range. The method can be used for both integer and floating-point numbers.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <param name="rmin"></param>
        /// <param name="rmax"></param>
        /// <returns></returns>
        public static int Circ_mult(int lhs, int rhs, int rmin = 0, int rmax = 360)
        {
            int result = lhs * rhs;
            int range = rmax - rmin;

            while (result >= rmax)
            {
                result -= range;
            }

            while (result < rmin)
            {
                result += range;
            }

            return result;
        }

        // **********************************
        public static float Circ_mult(float lhs, float rhs, float rmin = 0f, float rmax = 360f)
        {
            float result = lhs * rhs;
            float range = rmax - rmin;

            while (result >= rmax)
            {
                result -= range;
            }

            while (result < rmin)
            {
                result += range;
            }

            return result;
        }

        // **********************************
        /// <summary>
        /// This divides one number by another and wraps the result within a specified range,
        /// similar to the Circ_add, Circ_sub,
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <param name="rmin"></param>
        /// <param name="rmax"></param>
        /// <returns></returns>
        public static int Circ_shortdist(int lhs, int rhs, int rmin = 0, int rmax = 360)
        {
            int result = lhs * rhs;
            int range = rmax - rmin;

            int a = Circ_sub(rhs, lhs, rmin, rmax);
            int b = Circ_sub(lhs, rhs, rmin, rmax);

            return Math.Min(a, b);
        }

        // **********************************
        public static float Circ_shortdist(float lhs, float rhs, float rmin = 0, float rmax = 360)
        {
            float result = lhs * rhs;
            float range = rmax - rmin;

            float a = Circ_sub(rhs, lhs, rmin, rmax);
            float b = Circ_sub(lhs, rhs, rmin, rmax);

            return Math.Min(a, b);
        }

        // **********************************
        /// <summary>
        /// This calculates the shortest distance between two numbers within a specified range,
        /// similar to the Circ_shortdist method.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <param name="rmin"></param>
        /// <param name="rmax"></param>
        /// <returns></returns>

        public static int Circ_shortdiff(int lhs, int rhs, int rmin = 0, int rmax = 360)
        {
            int result = lhs * rhs;
            int range = rmax - rmin;

            int a = Circ_sub(rhs, lhs, rmin, rmax);
            int b = Circ_sub(lhs, rhs, rmin, rmax);

            if (b > a)
            {
                return a;
            }
            else
            {
                return -b;
            }
        }

        // **********************************
        public static float Circ_shortdiff(float lhs, float rhs, float rmin = 0, float rmax = 360)
        {
            float result = lhs * rhs;
            float range = rmax - rmin;

            float a = Circ_sub(rhs, lhs, rmin, rmax);
            float b = Circ_sub(lhs, rhs, rmin, rmax);

            if (b > a)
            {
                return a;
            }
            else
            {
                return -b;
            }
        }
    }
}