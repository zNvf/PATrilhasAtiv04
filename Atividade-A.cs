using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{
Console.Write("Qual sua idade? ");
var idade = int.Parse(Console.ReadLine());

Console.Write("Possui carteira de motorista? ");
string carteira = Console.ReadLine();

if (idade >= 18 && carteira == "sim"){
Console.WriteLine("\n\rVocê pode dirigir.");
}
else {
Console.WriteLine("\n\rVocê não pode dirigir.");
}

Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
