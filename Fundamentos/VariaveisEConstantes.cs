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
            Console.WriteLine("O valor da área da circunferencia é " + area);

            //Tipos internos
            bool chove = true;
            Console.WriteLine("Está a chover " + chove);

            byte idade = 36;
            Console.WriteLine("A sua idade é " + idade +" anos!");
        }
    }
}
