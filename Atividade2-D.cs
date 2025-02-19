using System;
using System.Collections.Generic;

class Program
{
public static void Main()
{
Console.Write("Digite uma palavra: ");
string palavra = Console.ReadLine();

string tamanho = (palavra.Length == 0) ? "\n\rA string está vazia." : "\n\rA string não está vazia.";

Console.WriteLine(tamanho);

Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
