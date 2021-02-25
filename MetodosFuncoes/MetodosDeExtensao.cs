using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.MetodosFuncoes {

    public static class ExtensoesInteiro {
        public static int Somar(this int num, int outroNumero) {
            return num + outroNumero;      
        }

        public static int Subtracao(this int num, int outroNumero) {
            return num - outroNumero;
        }
    }

    class MetodosDeExtensao {
        public static void Executar() {

        }
    }
}
