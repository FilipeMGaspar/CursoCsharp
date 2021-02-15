using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {
    class ParametrosVariaveis {

        public static void recepcionar(params string[] pessoas) {
            foreach (var pessoa in pessoas) {
                Console.WriteLine("Olá, {0}", pessoa);
            }
        }

        public static void Executar() {

        }
    }
}
