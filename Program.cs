using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("\t\t\tCALCULADORA IMC\n-----------------------------------------------------------------");

            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua altura em metros? Ex: 1,70 ");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o seu peso em Kg? Ex: 54,3");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("{0}, você tem {1} metros de altura e {2} Kg.", nome, altura, peso);

            Console.WriteLine("Seu imc é {0}", imc);
            Console.WriteLine("------------------------------------------------------------------");


        }
    }
}
