using System;
using System.Collections.Generic;

class Program
{
public static void Main()
{
Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

string comparacao = (numero > 0) ? "\n\rO número é maior que zero." : (numero < 0 ? "\n\rO número é menor que zero." : "\n\rO número é igual a zero.");

Console.WriteLine(comparacao);

Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
