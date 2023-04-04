namespace Exercício8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculoVolume volume = new CalculoVolume();

            Console.WriteLine($"O volume da lata de Óleo é de {volume.CalculoVolumeLata()}");
        }
    }
}