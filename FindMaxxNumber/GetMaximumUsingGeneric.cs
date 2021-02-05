using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxxNumber
{
   public class GetMaximumUsingGeneric<T> where T:IComparable
    {
        T firstNumber;
        T secondNumber;
        T thirdNumber;
        /// <summary>
        /// Create a three argument Constructor
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        public GetMaximumUsingGeneric(T firstNumber, T secondNumber, T thirdNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.thirdNumber = thirdNumber;
        }
        /// <summary>
        /// Create a No Argument Constructot
        /// </summary>
        public GetMaximumUsingGeneric() { }
        /// <summary>
        /// Method is Finding Maximum here we using Generic Class Concept to calling this Method
        /// </summary>
        /// <returns></returns>
        public T FindMaximumNumber()
        {
            T maximum = firstNumber;
            if (maximum.CompareTo(secondNumber) < 0)
                maximum = secondNumber;
            if (maximum.CompareTo(thirdNumber) < 0)
                maximum = thirdNumber;
            return maximum;
        }
        /// <summary>
        /// Extend the Max Method to take More then Three input Parameter
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public T FindMaximumNumber(params T[] input)
        {
            Array.Sort(input);
            int maximum = input.Length - 1;
            return input[maximum];
        }
    }
}
