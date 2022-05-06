/*
 * Disciplina : [Linguagem e Lógica de Programação]
 * Professor : Yuri Titi
 * Descrição : Ler três notas de um aluno, calcular a média
 * e informar se ele foi aprovado (Média ? 7),
 * reprovado (Média < 7) ou aprovado com
 * louvor (Média = 10)
 * Autor(a) : Iago Barbosa
 * Data atual : 24/03/2022
 */

using System;
					
public class Program
{
	public static void Main()
	{
		double nota1, nota2, nota3 = 0;
		string frase = "Digite a {0}ª nota: ";
		
		Console.WriteLine(frase, 1);
		nota1 = Convert.ToDouble( Console.ReadLine());
		
		Console.WriteLine(frase, 2);
		nota2 = Convert.ToDouble( Console.ReadLine());
		
		Console.WriteLine(frase, 3);
		nota3 = Convert.ToDouble( Console.ReadLine());
		
		calcularMedia (nota1, nota2, nota3);
	}
	static void calcularMedia (double nota1, double nota2, double nota3){
		double media = (nota1 + nota2+ nota3)/3;
		Console.WriteLine("A media de suas notas foram de: " + media);
		if(media > 7 && media < 10){
			Console.WriteLine("Voce foi aprovado com media: " + media);	
		}else if(media < 7){
			Console.WriteLine("Voce foi reprovado com media: " + media);	
		}else if(media == 10){
			Console.WriteLine("Aprovado com louvor, com media: " + media);
		}
	}
}