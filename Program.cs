Console.WriteLine("\t\t\tCALCULADORA IMC\n-----------------------------------------------------------------");

Console.WriteLine("Qual o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual a sua altura em metros? Ex: 1,70 ");
float altura = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Qual o seu peso em Kg? Ex: 54,3");
float peso = Convert.ToSingle(Console.ReadLine());

Individuo i =  new Individuo(nome, altura, peso);
double imc = i.IMC;
Console.WriteLine("\t\t\tPrimeira Parte\n-----------------------------------------------------------------");
Console.WriteLine(imc);
Console.WriteLine("\t\t\tSegunda Parte\n-----------------------------------------------------------------");
Console.WriteLine(i.ClassificacaoIMC(imc));
Console.WriteLine("\t\t\tTerceira Parte\n-----------------------------------------------------------------");
Console.WriteLine(i.PesoIdeal(altura, peso, imc));