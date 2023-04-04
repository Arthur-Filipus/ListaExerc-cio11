namespace Exercício1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixa = new CaixaRetangular();

            Console.WriteLine($"O volume da caixa é {caixa.CalcularVolume()}");
        }
    }
}