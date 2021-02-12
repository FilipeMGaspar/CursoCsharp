using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturasDeControlo
{
    class Estrutura_IF_ELSE
    {
        public static void Executar()
        {
            double nota = 6.0;

            if (nota >= 7.0){
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que a  sua obrigação");
            }else {
                Console.WriteLine("..: Em Recuperação :..");
                Console.WriteLine("Vamos Estudar!!!");
            }
        }
    }
}
