using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLinkedList
{
    /*El objetivo de la clase es que nos guarde un dato y obtenga la propiedad
     siguiente para saltar entre nodos o crear nodos*/
    public class CNODO
    {
        public int dato;
        //variable de referencia para apuntar al siguiente nodo.
        private CNODO siguiente = null;
        //uso de las propiedades
        public int Dato { get => dato; set =>dato=value; } 
        internal CNODO Siguiente { get => siguiente; set => siguiente = value; }
        //impresion
        public override string ToString()
        {
            return string.Format("{0}", dato);
        }

    }
}
