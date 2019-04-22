using System;
namespace Lab5_198896896
{
    public class Cuadrado : ICalcular
    {
        private int number;
        public Cuadrado(int number)
        {
            this.number = number;
        }
        public int Calcular()
        {
            int a = number * number;
            return a;
        }
    }
}
