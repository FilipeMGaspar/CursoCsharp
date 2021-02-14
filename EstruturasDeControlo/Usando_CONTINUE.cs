using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturasDeControlo
{
    class Usando_CONTINUE
    {
        public static void Executar() {
            int intervalo = 50;

            Console.WriteLine("Números pares entre 1 e {0}", intervalo);
            //utilização do continue; não deve ser utilizado
            for (int i = 1; i<=intervalo; i++) {
                if (i % 2 == 1){
                    continue;
                }
                Console.Write(i + " ");
            }
        }
    }
}
