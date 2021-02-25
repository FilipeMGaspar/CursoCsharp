using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.MetodosFuncoes {

    delegate double Operacao(double x, double y);

    class DelegateComLambda {
        public static void Executar() {
            Operacao sum = (x, y) => x + y;

        }
    }
}
