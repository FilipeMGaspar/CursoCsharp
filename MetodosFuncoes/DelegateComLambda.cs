using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.MetodosFuncoes {

    delegate double Operacao(double x, double y);

    class DelegateComLambda {
        public static void Executar() {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(sum(3, 3));
            Console.WriteLine(sub(5, 2));
            Console.WriteLine(mult(4, 3));
        }
    }
}
