/*
 * Disciplina : [Linguagem e Lógica de Programação]
 * Professor : Yuri Titi
 * Descrição : Faça um algoritmo que calcule a soma dos
 * números inteiros de 1 a 100.
 * Autor(a) : Iago Barbosa
 * Data atual : 24/03/2022
 */

using System;
					
public class Program
{
	public static void Main()
	{
		int valorMaximo = 50;
		int soma = 0;
		
		calcular(soma, valorMaximo);
	}
	static void calcular(int soma, int valorMaximo){
		for(int i = 0; i < valorMaximo; i++){
			Console.WriteLine(i + " + ");
			soma = soma + 101;
		}
		Console.WriteLine("");
		Console.WriteLine("A coma dos numeros inteiros e de: " + soma); 
	}
}