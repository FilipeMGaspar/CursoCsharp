using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Colecoes {
    class Queue {
        public static void Executar() {
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);
        }
    }
}
