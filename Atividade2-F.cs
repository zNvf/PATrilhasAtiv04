using System;
using System.Collections.Generic;

class Program
{
public static void Main()
{
Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

int numeroabs = (numero < 0) ? -numero : numero;

Console.WriteLine("\n\rO valor absoluto desse número é " + numeroabs);

Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
