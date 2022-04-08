Console.WriteLine("\t\t\tCALCULADORA IMC\n-----------------------------------------------------------------");

Console.WriteLine("Qual o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual a sua altura em metros? Ex: 1,70 ");
float altura = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Qual o seu peso em Kg? Ex: 54,3");
float peso = Convert.ToSingle(Console.ReadLine());

Individuo i =  new Individuo(nome, altura, peso);

double imc = i.CalculoIMC(altura, peso);

Console.WriteLine("{0}, você tem {1} metros de altura e {2} Kg.", nome, altura, peso);

Console.WriteLine("Seu imc é {0}", imc);
Console.WriteLine("------------------------------------------------------------------");




/*
if (imc < 17)
{    
    Console.WriteLine("Muito abaixo do peso");
}
else if( imc < 18.49 && imc > 17){
    Console.WriteLine("Abaixo do peso");
}
else if( imc > 18.5 && imc < 24.99)
{
    Console.WriteLine("Peso normal");
}
else if( imc > 25 && imc < 29.99)
{
    Console.WriteLine("Acima do peso");
}
else if( imc > 30 && imc < 34.99)
{
    Console.WriteLine("Obesidade I");
}
else if( imc > 35 && imc < 39.99)
{
    Console.WriteLine("Obesidade II");
}
else
{
    Console.WriteLine("Obesidade III (mórbida)");
}*/