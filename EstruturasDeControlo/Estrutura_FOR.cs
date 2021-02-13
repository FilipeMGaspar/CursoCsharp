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

            for (int i = 1; i<= tamanhoTurma; i++) {
                Console.WriteLine($"Nota do {i}º aluno: ");
                entrada = Console.ReadLine();

            }

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
