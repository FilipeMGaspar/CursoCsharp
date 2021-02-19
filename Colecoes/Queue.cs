using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Colecoes {
    class QueueColecoes {
        public static void Executar() {
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());//Peek() é um método
            Console.WriteLine(fila.Count);//cout é atributo

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();//fila
            salada.Enqueue(2);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
