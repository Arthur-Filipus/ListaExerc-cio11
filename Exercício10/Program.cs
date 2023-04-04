namespace Exercício10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculoTotal media = new CalculoTotal();

            Console.WriteLine($"A média Ponderada é de {media.CalculoMediaPonderada()}");
        }
    }
}