using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Asus";
            double preco = 999;

            Console.WriteLine("O "+ nome +" da marca "+ marca+ " custa "+preco);
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);
            Console.WriteLine($"A marca {marca} é bom!");
        }
    }
}
