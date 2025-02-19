using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{
Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());
if (numero % 3 == 0 && numero % 5 == 0)
Console.WriteLine("\n\rO número é divisível por 3 ou por 5!");
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
