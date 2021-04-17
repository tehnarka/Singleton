using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using single;
using ConsoleApp;
//в процесі розробки :)
namespace UnitTestSingle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var odinak = Odinak.Instance(); 
            var actual  = Odinak.Instance();
          
            Assert.AreEqual(odinak, actual);
        }
    }
}
