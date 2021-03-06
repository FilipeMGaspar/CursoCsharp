﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ExplorandoAPI {
    class UsandoTimeSpan {
        public static void Executar() {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            Console.WriteLine(intervalo);

            Console.WriteLine("\nMinutos: " + intervalo.Minutes);
            Console.WriteLine("Intervalo em Minutos: " + intervalo.TotalMinutes);

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);

            var tempo = chegada - largada;
            Console.WriteLine("\n"+tempo);

            Console.WriteLine("\n"+intervalo.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(11)));
            Console.WriteLine("Original: " + intervalo);

            Console.WriteLine("\n"+intervalo.ToString("g"));
            Console.WriteLine(intervalo.ToString("G"));
            Console.WriteLine(intervalo.ToString("c"));

            Console.WriteLine("\n" + TimeSpan.Parse("01:02:03").TotalMilliseconds);
        }
    }
}
