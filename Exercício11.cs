/*
 * Disciplina : [Linguagem e Lógica de Programação]
 * Professor : Yuri Titi
 * Descrição : Construa um programa que exiba a tabuada N.
 * Autor(a) : Iago Barbosa
 * Data atual : 17/03/2022
 */

using System;
					
public class Program
{
	public static int n = 0;
	
	public static void Main()
	{
		Console.WriteLine("Digite o numero da tabuada de sua preferencia");
		Program.n = Convert.ToInt32(Console.ReadLine());
		calculo();
	}
	static void calculo(){
		for(int i = 0; i <=10; i++){
			Console.WriteLine(Program.n + " X " + i + " = " + i * Program.n);	
		}
	}
}