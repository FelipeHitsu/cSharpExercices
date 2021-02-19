using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitandoDedos
{
    class Exercicios2
    {
        public void Exercicio1()
        {
            /*
             * Exercício 01
             * Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
             */

            int n;
            Console.Write("Insira um numero: ");
            n = int.Parse(Console.ReadLine());
            if(n < 0)
                Console.WriteLine("NEGATIVO");
            else
                Console.WriteLine("NÃO NEGATIVO");
        }

        public void Exercicio2()
        {
            /*
             * Exercício 02
             * Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
             */

            int n;
            Console.Write("Insira um numero: ");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR");

        }

        public void Exercicio3()
        {
            Console.Write("Insira 2 numeros: ");
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if(a % b == 0 || b % a == 0)
                Console.WriteLine("SAO MULTIPLOS");
            else
                Console.WriteLine("NAO SAO MULTIPLOS");
        }
    }
}
