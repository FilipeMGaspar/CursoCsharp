﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {
    class MetodosEstaticos {

        public class CalculadoraEstatica {
            public static int Somar(int a, int b) {
                return a + b;
            }

            public static int Multiplicar(int a, int b) {
                return a * b;
            }
        }
        public static void Executar() {
            //Métodos estáticos
            var resultado = CalculadoraEstatica.Multiplicar(2,2);
            Console.WriteLine("Resultado {0}", resultado);


        }
    }
}
