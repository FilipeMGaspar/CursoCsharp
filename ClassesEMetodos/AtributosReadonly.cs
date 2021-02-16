using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {

    public class Cliente {
        public string Nome;
        readonly DateTime Nascimento; //Private DateTime Nascimente;
        

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;

            //Nascimento = new DateTime(2020,10,10);
        }

        public string GetDataNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }


    class AtributosReadonly {
        public static void Executar() {
            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 2, 22));

            Console.Write("Nome: " + novoCliente.Nome);
            Console.Write(" | Data de Nascimento: " + novoCliente.GetDataNascimento());

            //novoCliente.Nascimento = new DateTime(2020, 5, 31);
        }
    }
}
