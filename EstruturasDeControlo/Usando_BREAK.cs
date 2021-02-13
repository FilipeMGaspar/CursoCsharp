using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturasDeControlo
{
    class Usando_BREAK
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51); // número aleatóreo entre 1 e 50

            Console.WriteLine("O número a encontrar: {0}", numero);

            for (int i = 1; i<=50; i++) {
                Console.WriteLine("{0} é o numero que qeremos? ", i);
                if (i == numero) {
                    Console.WriteLine("SIM!");
                } else {
                    Console.WriteLine("NÃO!");
                }

                
            }
        }
    }
}
