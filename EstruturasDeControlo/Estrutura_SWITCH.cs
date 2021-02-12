using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturasDeControlo
{
    class Estrutura_SWITCH
    {
        public static void Executar()
        {
            Console.Write("Avalie o meu Atendimento de [0 a 5]: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota) {
                case 0:
                    Console.WriteLine("Pésimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Mau");
                    break;
                case 3:
                    Console.WriteLine("Suficiente");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Excelente");
                    break;
                default:
                    Console.WriteLine("Avaliação inválida!");
                    break;
            }
            
            Console.WriteLine("Fim da avaliação");
        }
    }
}
