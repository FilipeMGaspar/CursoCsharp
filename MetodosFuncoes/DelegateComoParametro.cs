using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.MetodosFuncoes {
    class DelegateComoParametro {

        public delegate int Operacao(int x, int y);
        
        public static int Soma(int x, int y) {
            return x + y;
        }

        public static string Calculadora(Operacao op, int x, int y)

        public static void Executar() {

        }
    }
}
