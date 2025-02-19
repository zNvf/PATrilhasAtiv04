using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{
Console.Write("Deseja comprar um carro novo (sim ou não)? ");
string comprar = Console.ReadLine();
Console.Write("Possui dinheiro o suficiente (sim ou não)? ");
string dinheiro = Console.ReadLine();
if (comprar == "sim" && dinheiro == "sim")
Console.WriteLine("\n\rParabéns, você pode comprar um carro novo!");
else if (comprar == "não")
Console.WriteLine("\n\rVocê não deseja um carro novo.");
else if (comprar == "sim" && dinheiro == "não")
Console.WriteLine("\n\rVocê não pode comprar um carro novo.");
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
