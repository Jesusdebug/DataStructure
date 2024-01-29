using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recursive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive.Tests
{
    [TestClass()]
    public class FibonacciTests
    {
        //[TestMethod()]
        //public void fibTest()
        //{

        //    Assert.Fail();
        //}
        [TestMethod]
        public void Fibonacci_DevolverCorrect_UnoCuandoNesCero()
        {
            //arrange
            int resultado;
            //act
            resultado = Fibonacci.fib(0);
            //Assert
            Assert.AreEqual(1, resultado);
        }
        [TestMethod]
        public void Fibonacci_DevolvelUnoCuandoNEsUno()
        {

            //arrange
            int resultado;
            //Act
            resultado = Fibonacci.fib(1);

            //Assert
            Assert.AreEqual(1, resultado);
        }

    [TestMethod]
        public void Fibonacci_Devolver13CuandoNes5()
        {
            //arrange
            int resultado;
            //Act
            resultado = Fibonacci.fib(5);
            //Assert
            Assert.AreEqual(8, resultado);
        }
    }
}