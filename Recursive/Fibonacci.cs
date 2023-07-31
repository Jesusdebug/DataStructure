using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    public class Fibonacci
    {
        /*
         CALCULAR UN ELEMENTO DE LA SERIE DE FIBONACCI
        recordamos que cada elemento surge de sumar los dos elementos anteriores 
        teniendo la semilla de la serie,  que seria 1,1
        elementos 1,1,2,3,5,8,13
        1+1=2
        1+2=3
        2+3=5
        3+5=8
        5+8=13
        */
        public static int fib(int n)
        {
            int r = 0;
            //case inductive
            if(n>1)r = fib(n-1)+fib(n-2);
            //case base
            if (n <= 1) r = 1;
            return r;
        }
    }
}
