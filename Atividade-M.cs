using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{
Console.Write("Você é um membro ativo do clube : ");
string resposta = Console.ReadLine();
if (resposta == "nao" || resposta == "não" || resposta == "n" || resposta == "NÃO")
Console.WriteLine("\n\rPor favor, atualize sua inscrição para continuar usufruindo dos benefícios do clube.");
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
