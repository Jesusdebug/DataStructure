// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Exercise factorial data structure!");


int f = 0;
f = factorial(4);
Console.WriteLine(f);

/*FACTORIAL
 * 4!=4*3*2*1
 * 
 * 4!=4*3!
 * 3!=3*2!
 * 2!=2*1!
 * 1!=1
 * Total=24
 */
static int factorial(int number)
{
    int r=0;
    //inductive case
    if(number>1)r=number*factorial(number-1);
    //Base case
    if (number == 1) r = 1;
    return r;
}
