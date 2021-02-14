using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturasDeControlo
{
    class EstruturaIF
    {
        public static void Executar()
        {
            //Estrutura IF
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a Nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento [S/N]");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
                //bomComportamento = true;
            // outra forma  
            //bomComportamento = entrada == "S" || entrada == "s";
            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento) { 
                Console.WriteLine("Quadro de Honra");
            }

        }
    }
}
