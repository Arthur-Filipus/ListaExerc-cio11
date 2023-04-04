namespace Exercício3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculoVolume volume = new CalculoVolume();
            
            Console.WriteLine($"O volume do cilindro é de {volume.CalculoVolumeCilindro()}");
        }
    }
}