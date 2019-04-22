using System;
namespace Lab5_198896896
{
    public class PersonaQueSuma5 : ICalcular
    {
        private int number; 

        public PersonaQueSuma5(int number)
        {
            this.number = number;
        }

        public int Calcular()
        {
            return number + 5;
        }
    }
}
