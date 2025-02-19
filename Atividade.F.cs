using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{
Console.Write("Você deseja adicionar açúcar ou leite ao seu café (sim ou não): ");
string desejo = Console.ReadLine();
if (desejo == "sim")
Console.WriteLine("\n\rCafé com adicional preparado!");
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
