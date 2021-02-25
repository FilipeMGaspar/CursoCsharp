using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.MetodosFuncoes {
    class UsandoDelegates {

        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double a, double b) {
            return a + b;
        }

        static void MeuImprimirSoma(double a, double b) {
            Console.WriteLine(a +b);
        }
        
        public static void Executar() {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 3.5));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(5.6, 8);
            Console.WriteLine();

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(10.5, 9.5));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(23.4, 8.1);
        } 
    }
}
