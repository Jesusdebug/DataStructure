using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectLinkedList.Projects.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLinkedList.Projects.LinkedList.Tests
{
    [TestClass()]
    public class CListaLigadaTests
    {


        [TestMethod()]
        public void Transversa_DeberiaMostrarElementosCorrectos()
        {
            //Arrange
            CListaLigada cListaLigada = new CListaLigada();
            CNODO cNODO = new CNODO();

            //Act
            cListaLigada.Adicionar(1);
            cListaLigada.Adicionar(2);
            cListaLigada.Adicionar(3);
            //buscar el ultimo elemento 
            cNODO=cListaLigada.Buscar(3);

            //Assert
            // solo los muesta por sonsola, no se retorna datos
            Assert.AreEqual(3, cNODO.Dato);
        }

        [TestMethod()]
        public void Adicionar_DebeArgregarUnElmentoAlaLista()
        {
            //Arrange
            CListaLigada cListaLigada=new CListaLigada();
            //Act
            cListaLigada.Adicionar(1);
            //Assert
            Assert.IsFalse(cListaLigada.EstaVacio());
        }

        [TestMethod()]
        public void Vaciar_DebeDevolverTrueCuandoLaListaEstaVacia()
        {
            //Arrange
            CListaLigada cListaLigada= new CListaLigada();
            //Act
            cListaLigada.Adicionar(1);
            cListaLigada.Adicionar(2);
            cListaLigada.Vaciar();
            //Assert
            Assert.IsTrue(cListaLigada.EstaVacio());
        }

        [TestMethod()]
        public void EstaVacio_DevolverTrueSiLaListaEstaVacia()
        {
            //Arrange
            CListaLigada cListaLigada = new CListaLigada();

            //Act-Assert
            Assert.IsTrue(cListaLigada.EstaVacio());
        }

        [TestMethod()]
        public void Buscar_DevolverElnodoBuscado()
        {
            //Arrange
            CListaLigada cListaLigada = new CListaLigada();
            CNODO cNODO = new CNODO();
            //act
            cListaLigada.Adicionar(2);
            cListaLigada.Adicionar(4);
            cListaLigada.Adicionar(6);
            cListaLigada.Adicionar(8);
            cNODO = cListaLigada.Buscar(8);
            //Assert
            Assert.IsNotNull(cNODO);
            Assert.AreEqual(8, cNODO.Dato);
        }
    }
}