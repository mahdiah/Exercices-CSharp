using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RationnalLibrary;

namespace UnitTestRationnal
{
    [TestClass]
    public class UnitTestRationnal
    {
        [TestMethod]
        public void theConstructorShouldSetProperties()
        {
            Rationnal r = new Rationnal(1, 2);
            int numérateur = 1;
            int dénominateur = 2;
            Assert.AreEqual(numérateur, r.Numérateur);
            Assert.AreEqual(dénominateur, r.Dénominateur);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void theConstructorThrowExceptionIfDenominateurEgalZero()
        {
            Rationnal r = new Rationnal(1, 0);
           
        }

        [TestMethod]
        public void RationnalNormalizeTest()
        {
            Rationnal r = new Rationnal(420, -840);
            string ExpectedResult = "-1/2";
            Assert.AreEqual(ExpectedResult, r.ToString());
        }

        [TestMethod]
        public void RationnalAdditionTest()
        {
            Rationnal   r1 = new Rationnal(1, 2),
                        r2 = new Rationnal(-2, 7);
            Rationnal CurrentResult = r1 + r2;
            string ExpectedResult = "3/14";

            Assert.AreEqual(ExpectedResult, CurrentResult.ToString());


        }


    }
}
