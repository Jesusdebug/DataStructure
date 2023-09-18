// See https://aka.ms/new-console-template for more information
using ProjectLinkedList;

Console.WriteLine("Hello, World!");
/*LISTA LIGADA
 Es la primera estructura de datos que debemos conocer,  ya que sienta las bases para entender las demas structuras

    La lista ligada es un pariente del arreglo, mas eficiente, El arreglo debemos definirle un tamaño, por ende es monolítico es decir 
    que su tamaño no cambia y el proceso de borrado o insertado es comlejo. 
    La lista ligada da felixibilidad en que su tamaño es dinámico y la inserion y la eliminacion es mas sencilla.
TERMINOS
    *NODO Elemento a partir del cual se inicia la lista, guarda uno o varios datos, tiene  referencias a uno o varios nodos lo cual permite tener una secuencia
    al nodo siguiente.
    *
 */
CListaLigada listaLigada = new CListaLigada();
listaLigada.Adicionar(1);
listaLigada.Adicionar(2);
listaLigada.Adicionar(3);
listaLigada.Adicionar(4);
listaLigada.Adicionar(5);
listaLigada.Transversa();