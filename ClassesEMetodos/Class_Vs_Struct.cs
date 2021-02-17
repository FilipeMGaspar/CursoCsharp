using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {
    class Class_Vs_Struct {

        public struct SPonto {
            public int X;
            public int Y;
        }

        public struct CPonto {
            public int X;
            public int Y;
        }

        public static void Executar() {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1;
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X:{0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 X:{0}",copiaPonto1.X);
        }
    }
}
