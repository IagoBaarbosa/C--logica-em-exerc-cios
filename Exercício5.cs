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
		Console.WriteLine("Escreva um valor: ");
		int a = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Escreva outro valor que seja maior que o anterior: ");
		int b = Convert.ToInt32(Console.ReadLine());
		
		if( a > b) {
			Console.WriteLine("ERRO, le o enunciado novamente!");	
		}
		
		 double valorTotal = 0;
            for (int i = a; i <= b; i++) {
                if (i % 2 == 0) {
                    valorTotal += (i ^ 3);
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("A soma dos cubos dos numeros pares sao: " + valorTotal);
	}
}