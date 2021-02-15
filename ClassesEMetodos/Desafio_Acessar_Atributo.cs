using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {
    class Desafio_Acessar_Atributo {

        int a = 10;
        public static void Executar() {
            // Acessar a variavel a dentro método executar
            Desafio_Acessar_Atributo atributo = new Desafio_Acessar_Atributo();
            Console.WriteLine(atributo.a);
        }

    }
}
