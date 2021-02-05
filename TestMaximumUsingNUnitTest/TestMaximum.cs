using FindMaxxNumber;
using NUnit.Framework;

namespace TestMaximumUsingNUnitTest
{
    public class TestMaximum
    {
        /// <summary>
        /// PASSING THREE NUMBER WHEN MAXIMUM NUMBER PRESENT AT FIRST POSITION,RETURN TRUE OTHERWISE RETURN FALSE.
        /// </summary>

        [Test]
        public void GivenMaximumNumber_WhenAtFirstPosition_ReturnTrue()
        {
            GetMaximum maximum = new GetMaximum();
            int maximumNumber = maximum.FindMaximumNumber(400, 300, 200);
            Assert.AreEqual(400, maximumNumber);
        }

        ///<SUMMARY>
        ///PASSING THREE NUMBER WHEN MAXIMUM NUMBER PRESENT AT SECOND POSITION,RETURN TRUE OTHERWISE RETURN FALSE.
        ///<SUMMARY>
        [Test]
        public void GivenMaximumNumber_WhenAtSecondPosition_ReturnTrue()
        {
            GetMaximum maximum = new GetMaximum();
            int maximumNumber = maximum.FindMaximumNumber(300, 400, 100);
            Assert.AreEqual(400, maximumNumber);
        }

        ///<SUMMARY>
        ///PASSING THREE NUMBER WHEN MAXIMUM NUMBER PRESENT AT THIRD POSITION,RETURN TRUE OTHERWISE RETURN FALSE.
        ///<SUMMARY>
        [Test]
        public void GivenMaximumNumber_WhenAtThirdPosition_ReturnTrue()
        {
            GetMaximum maximum = new GetMaximum();
            int maximumNumber = maximum.FindMaximumNumber(100, 300, 400);
            Assert.AreEqual(400, maximumNumber);
        }
    }
}