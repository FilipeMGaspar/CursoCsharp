using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturasDeControlo
{
    class Estrutura_WHILE
    {
        public static void Executar()
        {
            int palpite = 0;
            Random aleatorio = new Random();

            int numeroSecreto = aleatorio.Next(1, 16); // Número aleatório entre 1 e 15
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado){
                Console.Write("Insira o seu Palpite: ");
                int.TryParse(Console.ReadLine(), out palpite);


            }
        }
    }
}
