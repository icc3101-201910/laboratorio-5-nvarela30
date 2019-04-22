using System;
namespace Lab5_198896896
{
    public class PerroFactorial : ICalcular
    {
        private int number;
        public PerroFactorial(int number) 
        {
            this.number = number;
        }
        public int Calcular()
        {
            int a = 1;
            for (int i = 1; i <= number; i++)
            {
                a *= i;
            }
            return a;
        }
    }
}
