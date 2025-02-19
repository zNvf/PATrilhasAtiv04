using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{
Console.Write("Você deseja comprar um produto: ");
string produto = Console.ReadLine();
if (produto == "sim" || produto == "s")
Console.WriteLine("\n\rObrigado pela compra!");
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
