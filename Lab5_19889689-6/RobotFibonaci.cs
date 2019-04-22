using System;
namespace Lab5_198896896
{
    public class RobotFibonacci : ICalcular
    {
        private int number;
        public RobotFibonacci(int number)
        {
            this.number = number;
        }

        public int Calcular()
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < number;i++)
            {
                int aux = a;
                a = b;
                b = aux + a;
            }
            return b;
        }
    }
}
