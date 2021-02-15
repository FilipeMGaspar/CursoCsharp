using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {
    class Desafio_Acessar_Atributo {

        int a = 10;// Variavel de instancia só possivel acessar através de construtor
        public static void Executar() {
            // Acessar a variavel a dentro método executar
            //Console.WriteLine(a); // Resposta errada
            
            Desafio_Acessar_Atributo atributo = new Desafio_Acessar_Atributo();//Construtor para a instancia
            Console.WriteLine(atributo.a);
        }

    }
}
