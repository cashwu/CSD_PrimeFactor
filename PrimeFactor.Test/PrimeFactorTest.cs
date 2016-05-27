using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeFactor.Test
{
    [TestClass]
    public class PrimeFactorTest
    {
        [TestMethod]
        public void PrimeFactorTest_2()
        {
            var p = new PrimeFactor();

            var expect = new []{2};
            var result = p.GetPrimeFactor(2);

            CollectionAssert.AreEqual(expect, result);
        }

        [TestMethod]
        public void PrimeFactorTest_1()
        {
            var p = new PrimeFactor();

            var expect = new int[0];
            var result = p.GetPrimeFactor(1);

            CollectionAssert.AreEqual(expect, result);
        }


    }
}
