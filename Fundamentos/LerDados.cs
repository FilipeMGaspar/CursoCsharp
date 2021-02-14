using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCsharp.Fundamentos
{
    class LerDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();//Ler dados da consola

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"O {nome} tem {idade} anos e ganha {salario}");
        }
    }
}
