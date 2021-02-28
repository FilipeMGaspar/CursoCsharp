using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ExplorandoAPI {
    class UsandoTimeSpan {
        public static void Executar() {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            Console.WriteLine(intervalo);

            Console.WriteLine("\nMinutos: " +intervalo.Minutes);
            Console.WriteLine("Intervalo em Minutos: " + intervalo.TotalMinutes);
        }
    }
}
