using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Tests
{
    [TestClass()]
    public class ExtensoraTests
    {
        [TestMethod()]
        public void InvierteTest()
        {
            Queue<double> n = new Queue<double>();
            Queue<double> n2;

            Queue<double> muestra = new Queue<double>();

            n.Enqueue(5);
            n.Enqueue(6);
            n.Enqueue(7);

            muestra.Enqueue(7);
            muestra.Enqueue(6);
            muestra.Enqueue(5);
            n2 = Extensora.Invierte(n);        

            CollectionAssert.AreEqual(n2,muestra);
            // Assert.Fail();
        }

        [TestMethod()]
        public void EldelMedioTest()
        {
            int test = Extensora.EldelMedio(4, 3, 2);
            Assert.AreEqual(test,3);
        }
    }
}