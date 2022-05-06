/*
 * Disciplina : [Linguagem e Lógica de Programação]
 * Professor : Yuri Titi
 * Descrição : Fazer um algoritmo que calcule e escreva a soma dos
 * 50 primeiros termos da seguinte serie:
 * 1000/1 - 997/2 + 994/3 - 991/4 + ...
 * Autor(a) : Iago Barbosa
 * Data atual : 24/03/2022
 */

using System;
					
public class Program
{
	public static void Main()
	{
		int denominador = 0;
		int numerador = 0;
		double somaTotal = 0;
		
		for(denominador = 0; denominador < 50; denominador ++){
			numerador = 1000 -(3*(denominador - 1));
			Console.WriteLine(numerador);
			Console.WriteLine(" " + denominador);
			Console.WriteLine("  ");
			
			if (denominador % 2 ==0){
				Console.WriteLine(" + ");
				somaTotal = somaTotal + (numerador / denominador);
			}else {
				Console.WriteLine(" - ");
				somaTotal = somaTotal - (numerador / denominador);
			}
		}
		Console.WriteLine("SOMA: " + somaTotal);
	}
}