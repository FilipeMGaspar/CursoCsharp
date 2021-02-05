using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Calculo da área da circunferencia
            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * (raio * raio);
            Console.WriteLine("O valor da área da circunferencia é "+area);
        }
    }
}
