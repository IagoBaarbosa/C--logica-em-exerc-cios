/*
 * Disciplina : [Linguagem e Lógica de Programação]
 * Professor : Yuri Titi
 * Descrição : Fazer um algoritmo para calcular e
 * escrever a seguinte soma:
 * 37x38/1 + 36x37/2 + 35x36/2 + ... + 1x2/37
 * 
 * Autor(a) : Iago Barbosa
 * Data atual : 24/03/2022
 */

using System;
					
public class Program
{
	public static void Main()
	{
		int denominador= 0;
	    int numeradorA = 0;
		int numeradorB = 0;
		double somaTotal = 0;
		
		for (denominador = 1; denominador <38; denominador++){
			numeradorA = 37 - (denominador - 1);
			numeradorB = numeradorA + 1;
			
			somaTotal = somaTotal + ((numeradorA * numeradorB)/denominador);
			Console.WriteLine(" ( " + numeradorA + " X " + numeradorB + " ) " + denominador);
		}
		Console.WriteLine("A soma e de: " + somaTotal);
	}
}