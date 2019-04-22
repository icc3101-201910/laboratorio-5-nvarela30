using System;
using System.Collections.Generic;
namespace Lab5_198896896
{
    public class Calculadora 
    {
        private int number;
        public List<ICalcular> Calculadoras;

        public Calculadora(int numero)
        {
            number = numero;
            Calculadoras = new List<ICalcular>();
        }
        public int GetNumber()
        {
            return number;
        }
        public int Calcular(int numero, int operacion)
        {
            number = Calculadoras[operacion].Calcular();
            return number;
        }
    }
}
