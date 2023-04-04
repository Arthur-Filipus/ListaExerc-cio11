namespace Exercício9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculoNota media = new CalculoNota();
            Console.WriteLine($"A média harmônica é de {media.CalculoMediaHarmonica()}");
        }
    }
}