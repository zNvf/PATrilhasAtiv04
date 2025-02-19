using System;
using System.Collections.Generic;

class Program
{
public static void Main()
{
Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

String respsota = (numero != 0) ? "\n\rO número é diferente de zero." : "\n\rO número é igual a zero.";

Console.WriteLine(respsota);

Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
