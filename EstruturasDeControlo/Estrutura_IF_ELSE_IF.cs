using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturasDeControlo
{
    class Estrutura_IF_ELSE_IF
    {
        public static void Executar()
        {
            Console.Write("Digite a nota do aluno: ");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0) {
                Console.WriteLine("Quadro de Honra!");
            } else if (nota >= 7.0) {
                Console.WriteLine("Aprovado!");
            } else if (nota >= 5.0) {
                Console.WriteLine("..: Em Recuperação :..");
            } else {
                Console.WriteLine("Reprovado!");
            }

            Console.WriteLine("Fim! !");
        }
        
    }
}
