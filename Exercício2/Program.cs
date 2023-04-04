namespace Exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculoTemperatura calculo = new CalculoTemperatura();
            
            Console.WriteLine($"A temperatura em Celcius é de {calculo.CalculoTemperaturaCelcius()}");
        }
    }
}