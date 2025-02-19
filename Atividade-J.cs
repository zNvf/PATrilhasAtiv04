using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{
Console.Write("Digite um número: ");
float numero = Convert.ToSingle(Console.ReadLine());
if (numero > 10 || numero < 0)
Console.WriteLine("\n\rNúmero invalido!");
Console.WriteLine("\n\rAperte alguma tecl para fechar...");
Console.ReadKey(true);
}
}
}
