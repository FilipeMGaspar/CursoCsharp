using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturasDeControlo
{
    class Estrutura_DO_WHILE
    {
        public static void Executar()
        {
            string entrada;
            do {
                Console.Write("Qual o seu nome: ");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo {0}",entrada);
                Console.Write("Deseja continuar [s/n]: ");
                entrada = Console.ReadLine();

            } while (entrada.ToLower() == "s");
        }
    }
}
