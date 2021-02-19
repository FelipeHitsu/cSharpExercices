using System;
using System.Globalization;

namespace ExercitandoDedos
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicios1 exercicios1 = new Exercicios1();
            Exercicios2 exercicios2 = new Exercicios2();

            bool quit = false;
            while (!quit)
            {
                //exercicios2.Exercicio3();

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    quit = true;
            }
        }

       
    }

}
