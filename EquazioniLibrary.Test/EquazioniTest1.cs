using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class EquazioniTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 3;
            double b = 4;
            bool risposta_aspettata = true;
            bool risposta = Equazioni.IsDeterminated(a, b);
            Assert.AreEqual(risposta, risposta_aspettata);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double a = 3;
            double b = 4;
            bool risposta_aspettata = true;
            bool risposta = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(risposta, risposta_aspettata);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double a = 4;
            double b = 5;
            double c = 6;
            bool risposta_aspettata = false;
            bool risposta = Equazioni.IsDegree2(a, b, c);
            Assert.AreEqual(risposta, risposta_aspettata);
        }
    }
}
