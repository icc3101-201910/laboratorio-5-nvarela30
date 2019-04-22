using System;
namespace Lab5_198896896
{
    public class Cubo : ICalcular
    {
        private int number;
        public Cubo(int number)
        {
            this.number = number;
        }
        public int Calcular()
        {
            int a = number * number * number;
            return a;
        }
    }
}
