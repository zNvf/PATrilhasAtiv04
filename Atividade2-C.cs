using System;
using System.Collections.Generic;

class Program
{
public static void Main()
{
Console.Write("Digite uma lista de números inteiros separados por espaço: ");
string entrada = Console.ReadLine();

List<int> lista = new List<int>();

foreach (var item in entrada.Split(' '))
{
int numero;
if (int.TryParse(item, out numero))
{
lista.Add(numero);
}

}

string resultado = (lista.Count == 0) ? "A lista está vazia." : "A lista não está vazia";
Console.WriteLine(resultado);

Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
