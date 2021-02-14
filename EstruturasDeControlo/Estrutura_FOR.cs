using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturasDeControlo
{
    class Estrutura_FOR
    {
        public static void Executar()
        {
            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            //Estrutura For
            for (int i = 1; i<= tamanhoTurma; i++) {
                Console.Write($"Nota do {i}º aluno: ");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            double mediaTurma = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine($"Média da turma {mediaTurma}");

            //Estrutora de repetição for
            //for (int i = 0; i<=10; i++) {
            //    Console.WriteLine($"O valor de i é : {i}");
            //}

            /* Estrutura de repetição While
            int i = 0;

            while(i <= 10)
            {
                Console.WriteLine($"O valor de i é {i}");
                i +=2;
            }
            */
        }

    }
}
