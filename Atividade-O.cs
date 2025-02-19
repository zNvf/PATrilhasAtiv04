using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{
Console.Write("Você deseja cancelar a operação : ");
string resposta = Console.ReadLine();
if (resposta == "não" || resposta == "nao" || resposta == "n" || resposta == "NÃO" || resposta == "NAO")
Console.WriteLine("\n\rPor favor, confirme o cancelamento da operação.");
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
