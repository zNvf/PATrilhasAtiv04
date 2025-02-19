using System;
{
class Program
{
public static void Main()
{
Console.Write("Digite o primeiro número : ");
int numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o segundo número : ");
int numero2 = Convert.ToInt32(Console.ReadLine());
int maior = (numero > numero2) ? numero : numero2;
Console.WriteLine("O maior número é " + maior);
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
