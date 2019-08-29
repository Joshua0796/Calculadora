using System;

namespace Calculadora.Entidades {
    public class Ecuaciones {
        
        public int valor1;
        public int valor2;
        public int mult;
        public int rest;
        public int sum;
        public int div;
        public string sumaecuacion = "";
        public string restaecuacion = "";
        public string multiecuacion = "";
        public string divisionecuacion = "";
        
        public string suma (int valor1, int valor2) {
            sum = valor1 + valor2;
            sumaecuacion = sum.ToString();
            return sumaecuacion;
        }
        public string resta (int valor1, int valor2) {
            rest = valor1 - valor2;
            restaecuacion = rest.ToString();
            return restaecuacion;
        }
        public string multiplicacion (int valor1, int valor2) {
            mult = valor1 * valor2;
            multiecuacion = mult.ToString();
            return multiecuacion;
        }
        public string division (int valor1, int valor2) {
            div = valor1 / valor2;
            divisionecuacion = div.ToString();
            return divisionecuacion;
        }
    }
}