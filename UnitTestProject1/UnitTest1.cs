using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Units;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            StringAssert.Contains("stroka", Program.test5());
        }



        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(10, Program.test1(5));
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreNotEqual(10, Program.test2(5));
        }




        [TestMethod]
        public void TestMethod8()
        {
            Assert.IsTrue(Program.test3(9));
        }
        [TestMethod]
        public void TestMethod9()
        {
            Assert.IsFalse(Program.test3(-3));
        }


        [TestMethod]
        public void TestMethod10()
        {
            Assert.IsInstanceOfType(Program.test1(3),typeof(int));
        }
        [TestMethod]
        public void TestMethod11()
        {
            Assert.IsNotInstanceOfType(Program.test1(3), typeof(string));
        }


        [TestMethod]
        public void TestMethod12()
        {
            Assert.IsNull(Program.test4(-3));
        }
        [TestMethod]
        public void TestMethod13()
        {
            Assert.IsNotNull(Program.test4(3));
        }


        
    }
}
