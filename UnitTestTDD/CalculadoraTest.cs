using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestTDD
{
    [TestClass()]
    public class CalculadoraTest
    {
        [TestMethod()]
        public int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}
