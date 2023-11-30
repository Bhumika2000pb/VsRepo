using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UILayer;
using System.IO;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        int res;
        [TestMethod]
        public void TestSquare()
        {
            //StringWriter w = new StringWriter();
            //Console.SetOut(w);
            int res=Program.square(2);
            Assert.AreEqual(4, res);
        }
    }
}
