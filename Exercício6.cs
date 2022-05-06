/*
 * Disciplina : [Linguagem e Lógica de Programação]
 * Professor : Yuri Titi
 * Descrição : Faça um algoritmo que lê uma temperatura
 * em Fahrenheit e calcula a temperatura
 * correspondente em Celsius. Ao final o
 * programa deve exibir as duas temperaturas.
 * - Usar a fórmula: C = (5 * (F-32) / 9)
 * 
 * Autor(a) : Iago Barbosa
 * Data atual : 24/03/2022
 */

using System;
					
public class Program
{
	public static void Main()
	{
		int resposta = 0;
		int temp = 0;
		
		Console.WriteLine("Para converter de Fahrenheit para Celsius digite [1] de Celsius para Fahrenheite digite [2]");
		resposta = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Digite uma temperatura: ");
		temp = Convert.ToInt32(Console.ReadLine());
		
		if( resposta == 1 ){
		 	Console.WriteLine("A temperatura convertida de Fahrenheit para Celsius e de: " + (5 * (temp - 32)/9));	
		}else if (resposta == 2){
			Console.WriteLine("A temperatura convertida de Celsius para Fahrenheit e de: " + (9 * temp + 106) /5);	
		}
	}
}