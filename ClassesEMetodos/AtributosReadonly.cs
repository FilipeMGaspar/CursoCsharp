using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {

    public class Cliente {
        public string Nome;
        DateTime Nascimente; //Private DateTime Nascimente;

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;

        }
    }

    class AtributosReadonly {
        public static void Executar() {

        }
    }
}
