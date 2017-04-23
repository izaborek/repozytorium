using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using klasa;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = new klaska1();
            double spr = a.Multipla(3);
            Assert.AreEqual(spr, 6);

        }
        
    }
}
