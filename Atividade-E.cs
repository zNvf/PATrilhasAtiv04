using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{
Console.Write("Digite seu nome : ");
string nome = Console.ReadLine();
Console.Write("Você é maior de idade (sim ou não): ");
string idade = Console.ReadLine();
int tamanho = nome.Length;
if (tamanho >= 3 && idade == "sim")
Console.WriteLine("\n\rAcesso permitido.");
else
Console.WriteLine("\n\rAcesso negado.");
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
