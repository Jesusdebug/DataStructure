using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLinkedList
{
    public class CListaLigada
    {
        /*
          El nodo ancla indica el inicio de mi lista ligada ya que muchas de las operaciones que realice deben empezar desde aquí
            VARIABLES
            * Trabajo nodo que vamos a trabajar
            * Trabajo2 auxiliar para busqueda de nodos, saber el siguiente.
         */
        //PRIMER NODO
        private CNODO ancla;
        private CNODO trabajo;
        private CNODO trabajo2;
        public CListaLigada()
        {
            //iniciamos el ancla
            ancla = new CNODO();
            //al iniciar la lista el ancla debe esta null
            //
            ancla.Siguiente = null;
        }
        /*TRANSVERSA
         Nos permite iterar sobre la estructura de datos pasando por cada nodo mediante el ancla 
        hasta ubicar el ultimo nodo donde se creara en nuevo elemento de la estructura
         */
        public void Transversa()
        {

            //incializa trabajo
            trabajo = ancla;
            //recorre hasta el ultimo elemento de la estructura
            while (trabajo.Siguiente != null)
            {
                //avanzamos trabajo
                trabajo = trabajo.Siguiente;
                //obtener el dato 
                int valor = trabajo.Dato;
                Console.WriteLine(valor);
            }
            Console.WriteLine();
        }

        /*ADICCIONAR
         Vamos a agregar datos a la estructura, para esto debemos movernos hasta el ultimo nodo 
        este proceso es muy similar a una transversa, con la diferencia que agregamos un nuevo nodo 
        al cual le asignamos el valor, lo conectamos a una referecia null, y conectamos el nodo anterior a el 
        nuevo nodo
         */
        public void Adicionar(int PDato)
        {

            //inicializamos trabajo
            trabajo = ancla;
            //iteramos hasta llegar el ultimo nodo
            while (trabajo.Siguiente != null)
            {

                trabajo = trabajo.Siguiente;
            }
            //creamos un nodo temporal 
            CNODO nodoTemporal = new CNODO();
            //asignamos un valor al nodo temporal
            nodoTemporal.Dato = PDato;
            //creamos una referencia a null, esto indica que este es el nuevo ultimo nodo
            nodoTemporal.Siguiente = null;
            //conectamos el nodo a la estrucutra
            trabajo.Siguiente = nodoTemporal;
        }
        /*vacial lista
            gracias al recolector de basura nosotros podemo desconectar la lista del ancla y
            ya el recolector realiza el proceso de borrado de los elementos de la estructura.
         */
        public void Vaciar()
        {
            ancla.Siguiente = null;
        }

        /*validar si una lista esta vacia*/
        public bool EstaVacio()
        {

            if (ancla.Siguiente == null) { return true; }
            return false;
        }
        /*buscar un elemento*/
        /*nos apoyamos de la propiedad trabajo2 mediante el ciclo while iremos 
         nodo a nodo preguntando por el dato que buscamos mediante la centencia if
        si no lo encontramos retornamos null
        */
        public CNODO Buscar(int Pdato)
        {
           // validar que no este vacia la estructura
            if (EstaVacio() == true) return null;
            //pasar la estrucutura a trabajo2
            trabajo2 = ancla;
            while (trabajo2.Siguiente != null)
            {
                //asignar la información de trabajo siguiente para validar sus valor 
                trabajo2=trabajo2.Siguiente;
                if (trabajo2.dato==Pdato)
                {
                    return trabajo2; 
                }
            }
            return null;


        }
    }
}
