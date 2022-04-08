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
    
}