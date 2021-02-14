using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturasDeControlo
{
    class Estrutura_FOREACH
    {
        public static void Executar()
        {
            var palavra = "Opa!";
            //Estrutura foreach
            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            Console.WriteLine();
            var alunos = new string[] {"Ana", "Bia", "Carlos", "Maria" }; 
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
