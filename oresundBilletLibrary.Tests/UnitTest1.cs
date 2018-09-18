using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace oresundBilletLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Bil b = new Bil("2222111", DateTime.Now);
        MC m = new MC("3355222", DateTime.Now);

        [TestMethod]
        public void TestBilPris()
        {
            Assert.AreEqual(410, b.Pris(false));
        }

        [TestMethod]
        public void TestK�ret�j()
        {
            Assert.AreEqual("�resund Bil", b.K�ret�jstype());
        }

        [TestMethod]
        public void TestMCPris()
        {
            Assert.AreEqual(210, m.Pris(false));
        }

        [TestMethod]
        public void TestK�ret�jstypeMc()
        {
            Assert.AreEqual("�resund MC", m.K�ret�jstype());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestK�ret�jNummerpladel�ngde()
        {
            var b = new Bil("AZ512252", DateTime.Now);

            b.Nummerpladel�ngde();

            Assert.Fail();
        }

        [TestMethod]
        public void TestBilPrisMedBrobizz()
        {
            Assert.AreEqual(161, b.Pris(true));
        }

        [TestMethod]
        public void TestMCPrisMedBrobizz()
        {
            Assert.AreEqual(73, m.Pris(true));
        }
    }
}
