using System;

class Program
{
static void Main()
{
Console.Write("Digite o primeiro número: ");
int numero1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

string mensagem;

mensagem = (numero2 != 0 && numero1 % numero2 == 0) ? "\n\rO número " + numero1 + " é divisível por " + numero2 : "\n\rO número não é divisível.";

Console.WriteLine(mensagem);

Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
