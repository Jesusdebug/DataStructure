
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace TDDCalculator
{
    public class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }
        //[TestMethod]
        //public void Sumar_DeberiaDevolverLaSumaCorrecta()
        //{
        //    //arrangure preparar, configurar las cosas necesarioas para que funcione la funcion
        //    Calculadora calculador= new Calculadora();
        //    //Act actuar realizar la operacion que estamos haciendo
        //    int resultado = calculador.Sumar(2, 2);
        //    //Assert confirmar el resultado de la operacion sea el esperado
        //    Assert.AreEqual(5, resultado);

        //}
    }
    [TestClass]
    public class CalculadoraTest {

        [TestMethod]
        public void CalculadoraDevuelve2Producto1mas1() {
      
            //Arrange
            int a,b;
            a= 1;
            b= 2;
            Calculadora calculadora = new Calculadora();
            int resultado;

            //Act
            resultado=calculadora.Sumar(a,b);

            //Assert
            Assert.AreEqual(2,resultado);
        }
    }
}