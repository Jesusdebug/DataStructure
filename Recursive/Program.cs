// See https://aka.ms/new-console-template for more information

/*FACTORIAL
 *Resolver un problema haciendo uso de la version  mas sencilla del mismo
 *Resolve problem do use version more simple way of it. 
 *contiene dos partes, caso inductivo y caso base
 *it has tow parts, inductive case and base case
 *inductivo: Es donde operamos invocando nuevamente  al metodo hasta complir la condición
 *inductive: calling the methodo again until the condition is met  
 *caso base: cuando obtenermos el resultado para la variable
 *base case: when we get the result the variable
 */
/*
 * PROBLEM DE FACTORIAL
F(4)
El factorial es multiplicar el valor pasado por todos lo que lo anteceden 
hasta llegar a 1 
The Factorial is to multiplying the value passed by all precede the it until reaching 1 
4!=4*3*2*1

4!=4*3!
	3!=3*2!
		2!=2*1!
			1!=1 (obtenemos la respuesta directa)
			1!=1 (we get answer)
 */

using Recursive;

//Console.WriteLine("Hello, World!");
//Console.WriteLine("welcome to factorial!");

int f = 0;
//f = Factorial(4);
Console.WriteLine("Hello, World!");
Console.WriteLine("welcome to Fibonacci!");
f = Fibonacci.fib(6);
Console.WriteLine(f);

//-------------------------------------------------------
static int Factorial(int n) {
	int r = 0;
	//caso inductivo
	if (n > 1) {
		r = n * Factorial(n - 1);
		Console.WriteLine("n*n-1 " + n  *  (n-1)+" iterado");
    }
	//caso base
	if(n==1) r=1;
	return r;
}

