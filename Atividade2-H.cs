using System;

class Program
{
static void Main()
{
Console.Write("Digite um número: ");
string str = Console.ReadLine();

int num;
string mensagem = int.TryParse(str, out num) ? "\n\rVocê digitou o número: " + num : "\n\rA entrada não é um número válido.";

Console.WriteLine(mensagem);

Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
