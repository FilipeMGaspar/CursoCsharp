using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {

    class ParametrosPorReferencia {
        public static void AlterarRef(ref int numero) {//passagem por referencia
            numero = numero + 1000; 
        }

        public static void AlterarOut(out int numero, out int numero2) {
            numero = 0;
            numero2 = 0;
            numero = numero + 15;
            numero2 = numero2 + 256;
        }

        public static void Executar() {
            int a = 3;
            AlterarRef(ref a);//passagem por referencia
            Console.WriteLine(a);

            //int b = 2;
            AlterarOut(out int b, out int c);//Método unidirecional
            Console.WriteLine("Utilizando o Out");
            Console.WriteLine($"{b} {c}");
        }
    }
}
