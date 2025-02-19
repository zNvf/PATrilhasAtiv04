using System;

class Program
{
static void Main()
{
Console.Write("Digite o número: ");
int numero1 = int.Parse(Console.ReadLine());

string mensagem;

mensagem = (numero1 != 0) ? "\n\rO número " + numero1 + " não é nulo " : "\n\rO número é nulo.";

Console.WriteLine(mensagem);

Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
