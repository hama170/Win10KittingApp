using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Win10KittingAppWinFormTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void メインシナリオ()
        {
            Assert.AreEqual(true, FileStreamInstall());
        }

        private bool FileStreamInstall()
        {
            throw new NotImplementedException();
        }
    }
}
