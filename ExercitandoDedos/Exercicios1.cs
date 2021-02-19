using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercitandoDedos
{
    class Exercicios1
    {
        public void Exercicio1()
        {
            /*
             * Exercício 01
             * Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
                    mensagem explicativa, conforme exemplos.
            */

            Console.WriteLine("Programa Soma");
            Console.Write("Insira o valor A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor B: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine("Resultado da soma de A:{0} + B:{1} é = {2}", a, b, resultado);

        }

        public void Exercicio2()
        {
            /*Exercício 02
             * Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
                    casas decimais conforme exemplos.
            Fórmula da área: area = π . raio2
            Considere o valor de π = 3.14159
             * 
             */

            Console.Write("Insiria o valor do raio de um circulo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pi = 3.14159;
            double area = pi * (Math.Pow(raio, 2));
            Console.WriteLine("Valor da área: " + area.ToString("F4", CultureInfo.InvariantCulture));
        }

        public void Exercicio3()
        {
            /*
             * Exercício 03
             * Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
                de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
             */
            int a, b, c, d;
            Console.Write("Insira o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor de B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor de C: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor de D: ");
            d = int.Parse(Console.ReadLine());

            int dif = a * b - c * d;
            Console.WriteLine("Diferença entre A:{0}, B:{1}, C:{2}, D:{3} = {4}", a, b, c, d, dif);
        }

        public void Exercicio4()
        {
            Console.Write("Insira o numero do Funcionario: ");
            int numeroFuncionario = int.Parse(Console.ReadLine());
            Console.Write("Insira seu numero de horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.Write("Insira o seu valor por hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = valorHora * horasTrabalhadas;
            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2",CultureInfo.InvariantCulture));
        }

        public void Exercicio5()
        {
            Console.Write("Insira o codigo da peça 1: ");
            int codPeca1 = int.Parse(Console.ReadLine());
            Console.Write("Insira a quantidade de peça 1: ");
            int qtdPeca1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor unitario peça 1: ");
            double valorUniPeca1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Insira o codigo da peça 2: ");
            int codPeca2 = int.Parse(Console.ReadLine());
            Console.Write("Insira a quantidade de peça 2: ");
            int qtdPeca2 = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor unitario peça 2: ");
            double valorUniPeca2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double total = qtdPeca1 * valorUniPeca1 + qtdPeca2 * valorUniPeca2;
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
        }

        public void Exercicio6()
        {
            /*
             * Exercício 06
             * Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
                a) a área do triângulo retângulo que tem A por base e C por altura.
                b) a área do círculo de raio C. (pi = 3.14159)
                c) a área do trapézio que tem A e B por bases e C por altura.
                d) a área do quadrado que tem lado B.
                e) a área do retângulo que tem lados A e B.
             */
            double a, b, c,aTriangulo,aCirculo,aTrapezio,aQuadrado,aRetangulo;

            Console.Write("Insira o Valor de A: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Insira o Valor de B: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Insira o Valor de C: ");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aTriangulo = a * c / 2.0;
            aCirculo = 3.14159 * c * c;
            aTrapezio = (a + b) / 2.0 * c;
            aQuadrado = b * b;
            aRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + aTriangulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + aCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + aTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + aQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + aRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }

    }
}
