using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{
Console.Write("Você é assinante da netflix (sim ou não)? ");
string assinatura = Console.ReadLine();
Console.Write("Já assistiu You (sim ou não)? ");
string serie = Console.ReadLine();
if (assinatura == "sim" && serie == "sim")
Console.WriteLine("\n\rÓtimo, agora você pode assistir à nova temporada!");
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
