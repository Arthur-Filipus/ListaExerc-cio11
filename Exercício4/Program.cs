namespace Exercício4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Combustivel consumo = new Combustivel();
            
            Console.WriteLine($"O consume de combustivel é de {consumo.ConsumoCombustivel()}");
        }
    }
}