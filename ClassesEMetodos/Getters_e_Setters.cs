﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {
    class Getters_e_Setters {

        public class Moto {
            private string Marca;
            private string Modelo;
            private int Cilindrada;

            public Moto(string marca, string modelo, int cilindrada) {
                Marca = marca;
                Modelo = modelo;
                Cilindrada = cilindrada;
            }

            public Moto() {

            }

            public string GetMarca() {
                return Marca;
            }
            public void SetMarca(string marca) {
                Marca = marca;
            }

            public string GetModelo() {
                return Modelo;
            }
            public void SetModelo(string modelo) {
                Modelo = modelo;
            } 


        }

        public static void Executar() {

        }
    }
}
