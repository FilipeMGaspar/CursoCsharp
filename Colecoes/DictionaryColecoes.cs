using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Colecoes {
    class DictionaryColecoes {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();//a chave int não aceita repetição

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: "+ filmes[2004]);
                Console.WriteLine(filmes.GetValueOrDefault(2004));
            }

            Console.WriteLine(filmes.ContainsValue("Amesésia"));
        }
    }
}
