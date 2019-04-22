using System;

namespace Lab5_198896896
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            PersonaQueSuma5 personaQueSuma5= new PersonaQueSuma5(numero);
            RobotFibonacci robotFibonacci = new RobotFibonacci(numero);
            PerroFactorial perroFactorial = new PerroFactorial(numero);
            Cubo cubo = new Cubo(numero);
            Cuadrado cuadrado = new Cuadrado(numero);
            Calculadora calculadora = new Calculadora(numero);

            calculadora.Calculadoras.Add(personaQueSuma5);
            calculadora.Calculadoras.Add(robotFibonacci);
            calculadora.Calculadoras.Add(perroFactorial);
            calculadora.Calculadoras.Add(cubo);
            calculadora.Calculadoras.Add(cuadrado);

            Console.Write("Cantidad de operaciones: ");
            int operaciones = Convert.ToInt32(Console.ReadLine());

            for (int i =1; i<= operaciones; i++)
            {
                Console.WriteLine("[1] PersonaQueSuma5");
                Console.WriteLine("[2] RobotFibonacci");
                Console.WriteLine("[3] PerroFactorial");
                Console.WriteLine("[4] Cubo");
                Console.WriteLine("[5] Cuadrado");
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    numero = calculadora.Calculadoras[0].Calcular();
                    Console.WriteLine(numero);
                }
                if (opcion == "2")
                {
                    numero = calculadora.Calculadoras[1].Calcular();
                    Console.WriteLine(numero);
                }
                if (opcion == "3")
                {
                    numero = calculadora.Calculadoras[2].Calcular();
                    Console.WriteLine(numero);
                }
                if (opcion == "4")
                {
                    numero = calculadora.Calculadoras[3].Calcular();
                    Console.WriteLine(numero);
                }
                if (opcion == "5")
                {
                    numero = calculadora.Calculadoras[4].Calcular();
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
