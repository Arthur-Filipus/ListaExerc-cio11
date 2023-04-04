namespace Exercício5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculoVolume volume = new CalculoVolume();

            Console.WriteLine($"O volume da esfera é de {volume.CalculoVolumeEsfera()}");
        }
    }
}