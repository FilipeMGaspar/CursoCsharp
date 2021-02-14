using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Fundamentos
{
    class operadorAtribuicao
    {
        public static void Executar()
        {
            //operadores de atribuição
            var num1 = 3;
            num1 = 7;
            num1 += 10; // num1 = num1 + 10;
            num1 -= 3; // num1 = num1 -3;
            num1 *= 5; // num1 = num1 * 5;
            num1 /= 2; //num1 = num1 /2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // a = a + 1; operador de incremento
            b--; // b = b - 1; operador de decremento

            Console.WriteLine(a);
            Console.WriteLine(b);

            //Não se preocupe com o código
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);
        }
    }
}
