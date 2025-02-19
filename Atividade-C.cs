using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{
Console.Write("Você possui mais de 21 anos (sim ou não)? ");
string idade = Console.ReadLine();
Console.Write("Possui diploma de ensino superior (sim ou não)? ");
string diploma = Console.ReadLine();
if (idade == "sim" && diploma == "sim")
Console.WriteLine("\n\rParabéns, você está qualificado para a vaga!");
else
Console.WriteLine("\n\rVocê não está qualificado.");
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
