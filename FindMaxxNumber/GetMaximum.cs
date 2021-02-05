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
        /// <summary>
        /// Pass Three string  and Return Alphabatically Largest string Number
        /// </summary>
        /// <param name="first_string"></param>
        /// <param name="second_string"></param>
        /// <param name="third_string"></param>
        /// <returns></returns>
        public string FindMaximumNumber(string first_string, string second_string, string third_string)
        {
            string maximum = first_string;
            if (maximum.CompareTo(second_string) < 0)
                maximum = second_string;
            if (maximum.CompareTo(third_string) < 0)
                maximum = third_string;
            return maximum;
        }
        /// <summary>
        /// By Using Generic Method trying to Calculate Calculate Maximum 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public T FindMaximumNumber<T>(T firstNumber, T secondNumber, T thirdNumber) where T : IComparable
        {
            T maximum = firstNumber;
            if (maximum.CompareTo(secondNumber) < 0)
                maximum = secondNumber;
            if (maximum.CompareTo(thirdNumber) < 0)
                maximum = thirdNumber;
            return maximum;
        }
    }
}
