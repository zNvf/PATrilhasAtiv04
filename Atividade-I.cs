using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{
Console.Write("Informe seu nome: ");
string nome = Console.ReadLine();
if (nome == "Gloria" || nome == "Wilson")
Console.WriteLine("\n\rOlá, bem-vindo(a) de volta!");
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
