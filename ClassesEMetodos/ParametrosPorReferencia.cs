﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {

    class ParametrosPorReferencia {
        public static void AlterarRef(ref int numero) {//passagem por referencia
            numero = numero + 1000; 
        }

        public static void AlterarOut(out int numero) {
            numero = 0;
            numero = numero + 15;
        }

        public static void Executar() {
            int a = 3;
            AlterarRef(ref a);//passagem por referencia
            Console.WriteLine(a);

            //int b = 2;
            AlterarOut(out int b);
            Console.WriteLine(b);
        }
    }
}
