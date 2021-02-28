using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ExplorandoAPI {
    class UsandoDateTime {
        public static void Executar() {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);
            
            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            //Sem hora
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);
        }
    }
}
