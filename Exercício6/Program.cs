namespace Exercício6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculoTemperatura calculo = new CalculoTemperatura();

            Console.WriteLine($"A temperatura em Fahrenheit é de {calculo.CalculoTemperaturaFahrenheit()}");
        }
    }
}