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
            Console.WriteLine("A sua idade é de" + idade +" anos!");

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de golos " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("O valor do salário máximo é " + salario);

            int menorValorInt = int.MaxValue;
            Console.WriteLine("O menor valor inteiro é " + menorValorInt);

            uint populacaoBrasileira = uint.MaxValue;
            Console.WriteLine("População brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor long " + menorValorLong);
        }
    }
}
