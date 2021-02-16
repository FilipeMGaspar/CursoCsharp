using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {

    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia }

    public class Filme {
        public string Titulo;
        public Genero GeneneroDoFilme;
    }

    class Enumeracoes {
        public static void Executar() {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);
        }
    }
}
