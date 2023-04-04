namespace Exercício7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TotalSalario salario = new TotalSalario();
            
            Console.WriteLine($"O salário total do vendedor é de {salario.CalculoSalario()}");
        }
    }
}