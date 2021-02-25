using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.MetodosFuncoes {
    class ExemploLambda {
        public static void Executar() {
            Action algoNoConsole = () => {
                Console.WriteLine("Lambda co C#");
            };

            algoNoConsole();

            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

        }
    }
}
