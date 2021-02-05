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
        ///<SUMMARY>
        ///PASSING THREE FLOAT NUMBER WHEN MAXIMUM FLOAT NUMBER PRESENT AT FIRST POSITION,RETURN TRUE OTHERWISE RETURN FALSE.
        ///<SUMMARY>
        [Test]
        public void GivenFlotMaximumNumber_WhenAtFirstPosition_ReturnTrue()
        {
            GetMaximum maximum = new GetMaximum();
            float maximumNumber = maximum.FindMaximumNumber(4f, 3f, 1f);
            Assert.AreEqual(4f, maximumNumber);
        }

        ///<SUMMARY>
        ///PASSING THREE FLOAT NUMBER WHEN MAXIMUM FLOAT NUMBER PRESENT AT SECOND POSITION,RETURN TRUE OTHERWISE RETURN FALSE.
        ///<SUMMARY>
        [Test]
        public void GivenFlotMaximumNumber_WhenAtSecondPosition_ReturnTrue()
        {
            GetMaximum maximum = new GetMaximum();
            float maximumNumber = maximum.FindMaximumNumber(3f, 4f, 1f);
            Assert.AreEqual(4f, maximumNumber);
        }

        ///<SUMMARY>
        ///PASSING THREE FLOAT NUMBER WHEN MAXIMUM FLOAT NUMBER PRESENT AT THIRD POSITION,RETURN TRUE OTHERWISE RETURN FALSE.
        ///<SUMMARY>
        [Test]
        public void GivenFlotMaximumNumber_WhenAtThirdPosition_ReturnTrue()
        {
            GetMaximum maximum = new GetMaximum();
            float maximumNumber = maximum.FindMaximumNumber(1f, 3f, 4f);
            Assert.AreEqual(4f, maximumNumber);
        }
        ///<SUMMARY>
        ///PASSING THREE STRING  WHEN MAXIMUM STRING  PRESENT AT FIRST POSITION,RETURN TRUE OTHERWISE RETURN FALSE.
        ///<SUMMARY>
        [Test]
        public void GivenStringMaximumNumber_WhenAtFirstPosition_ReturnTrue()
        {
            GetMaximum maximum = new GetMaximum();
            string maximumNumber = maximum.FindMaximumNumber("C", "A", "B");
            Assert.AreEqual("C", maximumNumber);
        }

        ///<SUMMARY>
        ///PASSING THREE STRING  WHEN MAXIMUM STRING  PRESENT AT SECOND POSITION,RETURN TRUE OTHERWISE RETURN FALSE.
        ///<SUMMARY>
        [Test]
        public void GivenStringMaximumNumber_WhenAtSecondPosition_ReturnTrue()
        {
            GetMaximum maximum = new GetMaximum();
            string maximumNumber = maximum.FindMaximumNumber("A", "C", "B");
            Assert.AreEqual("C", maximumNumber);
        }

        ///<SUMMARY>
        ///PASSING THREE STRING  WHEN MAXIMUM STRING  PRESENT AT THIRD POSITION,RETURN TRUE OTHERWISE RETURN FALSE.
        ///<SUMMARY>
        [Test]
        public void GivenStringMaximumNumber_WhenAtThirdPosition_ReturnTrue()
        {
            GetMaximum maximum = new GetMaximum();
            string maximumNumber = maximum.FindMaximumNumber("B", "A", "C");
            Assert.AreEqual("C", maximumNumber);
        }
        ///<SUMMARY>
        ///PASSING THREE INTEGER BY USING GENERIC CONCEPT WHEN MAXIMUM INTEGER PRESENT AT FIRST POSITION,RETURN TRUE OTHERWISE RETURN FALSE.
        ///<SUMMARY>
        [Test]
        public void GivenIntegerMaximumNumber_WhenAtFirstPosition_ReturnTrue()
        {
            GetMaximum maximum = new GetMaximum();
            int maximumNumber = maximum.FindMaximumNumber<int>(400, 300, 200);
            Assert.AreEqual(400, maximumNumber);
        }

        ///<SUMMARY>
        ///PASSING THREE FLOAT BY USING GENERIC CONCEPT WHEN MAXIMUM FLOAT  PRESENT AT FIRST POSITION,RETURN TRUE OTHERWISE RETURN FALSE.
        ///<SUMMARY>
        [Test]
        public void GivenFloatMaximumNumber_WhenAtFirstPosition_ReturnTrue()
        {
            GetMaximum maximum = new GetMaximum();
            float maximumNumber = maximum.FindMaximumNumber<float>(400f, 300f, 200f);
            Assert.AreEqual(400f, maximumNumber);
        }

        ///<SUMMARY>
        ///PASSING THREE STRING BY USING GENERIC CONCEPT WHEN MAXIMUM STRING PRESENT AT FIRST POSITION,RETURN TRUE OTHERWISE RETURN FALSE.
        ///<SUMMARY>
        [Test]
        public void GivenStringMaximumNumber_WhenAtFirsttPosition_ReturnTrue()
        {
            GetMaximum maximum = new GetMaximum();
            string maximumNumber = maximum.FindMaximumNumber<string>("C", "B", "C");
            Assert.AreEqual("C", maximumNumber);
        }
        ////<SUMMARY>
        ////PASSING THREE INTEGER BY USING GENERIC CONCEPT WHEN MAXIMUM INTEGER  PRESENT AT FIRST POSITION,RETURN TRUE OTHERWISE RETURN FALSE.
        ////<SUMMARY>
        [Test]
        public void GivenNumber_WhenTested_ReturnMaximumIntegerNumber()
        {
            GetMaximumUsingGeneric<int> maximum = new GetMaximumUsingGeneric<int>(400, 300, 200);
            int maximumNumber = maximum.FindMaximumNumber();
            Assert.AreEqual(400, maximumNumber);
        }
        ////<SUMMARY>
        ////PASSING THREE FLOAT BY USING CLASS GENERIC CONCEPT WHEN MAXIMUM FLOAT  PRESENT AT FIRST POSITION,RETURN TRUE OTHERWISE RETURN FALSE.
        ////<SUMMARY>
        [Test]
        public void GivenNumber_WhenTested_ReturnMaximumFloatNumber()
        {
            GetMaximumUsingGeneric<float> maximum = new GetMaximumUsingGeneric<float>(400f, 300f, 200f);
            float maximumNumber = maximum.FindMaximumNumber();
            Assert.AreEqual(400f, maximumNumber);
        }
        ////<SUMMARY>
        ////PASSING THREE STRING BY USING CLASS GENERIC CONCEPT WHEN MAXIMUM STRING PRESENT AT FIRST POSITION,RETURN TRUE OTHERWISE RETURN FALSE.
        ////<SUMMARY>
        [Test]
        public void GivenNumber_WhenTested_ReturnMaximumString()
        {
            GetMaximumUsingGeneric<string> maximum = new GetMaximumUsingGeneric<string>("A", "B", "C");
            string maximumNumber = maximum.FindMaximumNumber();
            Assert.AreEqual("C", maximumNumber);
        }

    }
}