using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Fundamentos
{
    class Inferencias
    {
        public static void Executar()
        {
            var nome = "Filipe";
            //nome = 123; !
            Console.WriteLine("O meu nome é "+nome);

            var idade = 36;
            //idade = 36;
            Console.WriteLine("E tenho "+idade+" anos");

            int a;
            a = 2;
            int b =3;

            Console.WriteLine("A soma de "+ a +" com " + b + " tem o valor de "+ (a+b));
        }
    }
}
