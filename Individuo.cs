public class Individuo
{
    public string Nome { get; }
    public float Altura { get; set; }
    public float Peso { get; set;}

    public Individuo( string nome, float altura, float peso)
    {
        Nome = nome;
        Altura = altura;
        Peso = peso;
    }

    public double CalculoIMC(float altura, float peso) => peso / (altura * altura);


     public String toString(double imc)
    {
        return Nome + " sua altura é " + Math.Round(Altura, 2) + " e seu peso é " + Math.Round(Peso, 2) + ". \nSeu IMC é " + Math.Round(imc, 2) + ".";
    }

    public String ClassificacaoIMC(double imc)
    {
        if (imc < 17) return "Muito abaixo do peso.";
        
        else if( imc < 18.49 && imc > 17) return "Abaixo do peso.";
        
        else if( imc > 18.5 && imc < 24.99) return "Peso normal.";
        
        else if( imc > 25 && imc < 29.99) return "Acima do peso.";
        
        else if( imc > 30 && imc < 34.99) return "Obesidade I.";
        
        else if( imc > 35 && imc < 39.99) return "Obesidade II.";
        
        return "Obesidade III (mórbida).";
    }

    public String PesoIdeal(float altura, float peso, double imc)
    {
        double pesoIdeal = 0.0;

        if (imc < 18.5)
        {
            pesoIdeal = (18.5 * altura* altura) - peso;

            return "Para o peso ideal, é necessário ganhar " + Math.Round(pesoIdeal,2) + "Kg.";
        }

        else if(imc > 24.9)
        {
            pesoIdeal = peso - (24.9 * altura * altura);

            return "Para o peso ideal, é necessário perder " + Math.Round(pesoIdeal, 2) + " Kg.";
        }

        return "Não precisa ganhar ou perder peso.";
    }
}