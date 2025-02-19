using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{
Console.Write("Digite um número : ");
float numero = float.Parse(Console.ReadLine());
if (numero != 0)
Console.WriteLine("\n\rO número é diferente de zero.");
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
