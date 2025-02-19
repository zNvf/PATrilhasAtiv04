using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{
Console.Write("Digite uma palavra : ");
string palavra = Console.ReadLine();
if (palavra != "")
Console.WriteLine("\n\rA palavra não é vazia.");
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
