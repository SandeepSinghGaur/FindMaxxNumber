using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxxNumber
{
   public class GetMaximumUsingGeneric<T> where T : IComparable
    {
        T firstNumber;
        T secondNumber;
        T thirdNumber;

        public GetMaximumUsingGeneric(T firstNumber, T secondNumber, T thirdNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.thirdNumber = thirdNumber;
        }
        public T FindMaximumNumber()
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
