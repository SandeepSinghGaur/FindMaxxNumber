using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxxNumber
{
    public class GetMaximum
    {
        /// <summary>
        /// Pass Three Integer and Return Maximum Number
        /// </summary>
        /// <param name="X_Number"></param>
        /// <param name="Y_Number"></param>
        /// <param name="Z_Number"></param>
        /// <returns></returns>
       public int FindMaximumNumber(int X_Number, int Y_Number, int Z_Number)
        {
            int maximum = X_Number;
            if (maximum.CompareTo(Y_Number) < 0)
                maximum = Y_Number;
            if (maximum.CompareTo(Z_Number) < 0)
                maximum = Z_Number;
            return maximum;
        }
        /// <summary>
        /// Pass Three Float Number and Return Largest Float Number
        /// </summary>
        /// <param name="X_Number"></param>
        /// <param name="Y_Number"></param>
        /// <param name="Z_Number"></param>
        /// <returns></returns>
        public float FindMaximumNumber(float X_Number, float Y_Number, float Z_Number)
        {
            float maximum = X_Number;
            if (maximum.CompareTo(Y_Number) < 0)
                maximum = Y_Number;
            if (maximum.CompareTo(Z_Number) < 0)
                maximum = Z_Number;
            return maximum;
        }
    }
}
