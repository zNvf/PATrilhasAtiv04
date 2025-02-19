using System;
{
class Program
{
public static void Main()
{
Console.Write("Digite um número : ");
int numero = Convert.ToInt32(Console.ReadLine());
string resposta = (numero % 2 == 0) ? "Par" : "Ímpar";
Console.WriteLine("O número " + numero + " é " + resposta);
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
