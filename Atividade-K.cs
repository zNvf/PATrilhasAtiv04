using System;
namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	

			Console.Write("Você é um robô : ");
			string resposta = Console.ReadLine();
		 	
		 	if (resposta == "não" || resposta == "n" || resposta == "nao"){
				Console.WriteLine("\n\rPor favor, prove que você não é um robô.");
				}
		
			Console.WriteLine("\n\rAperte alguma tecla para fechar...");
			Console.ReadKey(true);
		}
	}
}
