using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL_TIME;

namespace UnitTest_Operator
{
    [TestClass]
    public class TestOperator
    {
        [TestMethod]
        public void TestNormalCase()
        {
            Time t1 = new Time(7, 15);
            Time t2 = new Time(7, 35);
            Time currentResult = t1 + t2;
            Time expectedResult = new Time(14, 50);

            Assert.AreEqual(expectedResult, currentResult);
        }


        [TestMethod]
        public void TestOverflowMinutes()
        {
            Time t1 = new Time(7, 35);
            Time t2 = new Time(7, 35);
            Time currentResult = t1 + t2;
            Time expectedResult = new Time(15, 10);

            Assert.AreEqual(expectedResult, currentResult);
        }

        [TestMethod]
        public void TestNormalCaseOpMinus()
        {
            Time t1 = new Time(8, 35);
            Time t2 = new Time(7, 15);
            Time currentResult = t1 - t2;
            Time expectedResult = new Time(1, 20);

            Assert.AreEqual(expectedResult, currentResult);
        }


        [TestMethod]
        public void TestMunitesNegativeOpMinus()
        {
            Time t1 = new Time(8, 15);
            Time t2 = new Time(7, 25);
            Time currentResult = t1 - t2;
            Time expectedResult = new Time(0, 50);

            Assert.AreEqual(expectedResult, currentResult);
        }

        [TestMethod]
        public void TestMultiplcateWithInt()
        {
            Time t1 = new Time(8, 15);
            int k = 2;
            Time currentResult = t1 * k;
            Time expectedResult = new Time(16, 30);

            Assert.AreEqual(expectedResult, currentResult);
        }


        [TestMethod]
        public void TestDividedWithInt()
        {
            Time t1 = new Time(6, 30);
            int k = 5;
            Time currentResult = t1 / k;
            Time expectedResult = new Time(1, 18);

            Assert.AreEqual(expectedResult, currentResult);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDividedByZero()
        {
            Time t1 = new Time(1, 5);
            int k = 0;
            Time currentResult = t1 / k;
           
        }

        [TestMethod]
        public void TestTime1PlusGrandTime2isTrue()
        {
            Time t1 = new Time(6, 30);
            Time t2 = new Time(5, 45);
            bool currentResult = t1 > t2;
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, currentResult);
        }

        [TestMethod]
        public void TestTime1PlusGrandTime2isFalse()
        {
            Time t1 = new Time(6, 30);
            Time t2 = new Time(6, 45);
            bool currentResult = t1 > t2;
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, currentResult);
        }

        [TestMethod]
        public void TestTime2PlusGrandTime1isTrue()
        {
            Time t1 = new Time(6, 30);
            Time t2 = new Time(6, 45);
            bool currentResult = t1 < t2;
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, currentResult);
        }

        [TestMethod]
        public void TestTime2PlusGrandTime1isFalse()
        {
            Time t1 = new Time(6, 30);
            Time t2 = new Time(5, 45);
            bool currentResult = t1 < t2;
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, currentResult);
        }


        [TestMethod]
        public void TestTime1EgalTime2IsTrue()
        {
            Time t1 = new Time(6, 30);
            Time t2 = new Time(6, 30);
            bool currentResult = t1 == t2;
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, currentResult);
        }

        [TestMethod]
        public void TestTime1EgalTime2Isfalse()
        {
            Time t1 = new Time(6, 30);
            Time t2 = new Time(6, 45);
            bool currentResult = t1 == t2;
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, currentResult);
        }

        [TestMethod]
        public void TestTime1DifferentTime2IsTrue()
        {
            Time t1 = new Time(6, 30);
            Time t2 = new Time(6, 35);
            bool currentResult = t1 != t2;
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, currentResult);
        }

        [TestMethod]
        public void TestTime1DifferentTime2Isfalse()
        {
            Time t1 = new Time(6, 30);
            Time t2 = new Time(6, 30);
            bool currentResult = t1 != t2;
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, currentResult);
        }

        [TestMethod]
        public void TestTime1EgalslMethodTime2IsTrue()
        {
            Time t1 = new Time(6, 30);
            Time t2 = new Time(6, 30);
            bool currentResult = t1.Equals(t2);
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, currentResult);
        }

        [TestMethod]
        public void TestTime1EgalsMethodTime2Isfalse()
        {
            Time t1 = new Time(6, 30);
            Time t2 = new Time(6, 45);
            bool currentResult = t1.Equals(t2);
            bool expectedResult = false;

            Assert.AreEqual(expectedResult, currentResult);
        }


        [TestMethod]
        public void TestTimeToConvertFloat()
        {
            Time t1 = new Time(6,15);
           
            float currentResult = (float)t1 ;
            float expectedResult = 6.25F ;

            Assert.AreEqual(expectedResult, currentResult);
        }

       

        [TestMethod]
        public void TestFloatToConvertTime()
        {
            float f = 6.50F;
            Time currentResult = (Time)f;
            Time expectedResult = new Time(6,30);

            Assert.AreEqual(expectedResult, currentResult);
        }


        [TestMethod]
        public void TestTimeToConvertToString()
        {
            Time t1 = new Time(6, 30);
            string currentResult = (string)t1;
            string expectedResult = "6:30'";

            Assert.AreEqual(expectedResult, currentResult);
        }


        [TestMethod]
        public void TestStringToConvertToTime()
        {
            
            string s = "06:30'";
            Time currentResult = (Time)s;
            Time expectedResult = new Time(6, 30);

            Assert.AreEqual(expectedResult, currentResult);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestStringToConvertToTimeIsFalse()
        {

            string s = "6h:30'";
            Time currentResult = (Time)s;
            Time expectedResult = new Time(6, 30);

           // Assert.AreEqual(expectedResult, currentResult);
        }
    }
}
