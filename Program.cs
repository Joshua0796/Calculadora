using System;
using Calculadora.Entidades;

namespace Calculadora {
    class Program {
        static void Main (string[] args) {
            string v1 = "";
            string v2 = "";

            Ecuaciones ec = new Ecuaciones ();
            Console.WriteLine ("Digite primer valor: ");
            v1 = Console.ReadLine ();
            int val1 = int.Parse (v1);
            Console.WriteLine ("Digite Segundo valor: ");
            v2 = Console.ReadLine ();
            int val2 = int.Parse (v2);
            Console.WriteLine ("Escriba tipo de ecuacion: ");
            string tipoEc = Console.ReadLine ();

            if (tipoEc == "Suma") {
                ec.suma (val1, val2);
                Console.WriteLine (ec.sumaecuacion);
            }
            if (tipoEc == "Resta") {
                ec.resta (val1, val2);
                Console.WriteLine (ec.restaecuacion);
            }
            if (tipoEc == "Multiplicacion") {
                ec.multiplicacion (val1, val2);
                Console.WriteLine(ec.multiecuacion);
            }
            if (tipoEc == "Division") {
                ec.division (val1, val2);
                Console.WriteLine(ec.divisionecuacion);
            } else {
                return;
            }
        }
    }
}