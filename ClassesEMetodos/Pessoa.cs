using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {
    class Pessoa {
        //atributos
        public string Nome; // valor padrão null 
        public int Idade; // tem valor padrão 0

        //Métodos
        public string Apresentar() {
            return string.Format($"Olá o meu nome é {Nome} e tenho {Idade} anos"); 
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}
