using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {

    class ParametrosPorReferencia {
        public static void AlterarRef(int numero) {
            numero = numero + 1000; 
        }

        public static void AlterarOut(int numero) {
            numero = numero + 15;
        }

        public static void Executar() {

        }
    }
}
