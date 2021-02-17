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

        }
    }
}
