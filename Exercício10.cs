 * Descrição : Anacleto tem 1,50m e cresce 2
 * centímetros por ano, enquanto Felisberto tem
 * 1,10 e cresce 3 centímetros por ano. Construa
 * um programa que calcule e apresente quantos
 * anos serão necessários para que Felisberto
 * seja maior que Anacleto
 * 
 * Autor(a) : Iago Barbosa
 * Data atual : 24/03/2022
 */

using System;
					
public class Program
{
	public static int i = 0;
	public static void Main()
	{
		calcularAno();
		Console.WriteLine("O total de anos que demoraria seria de: " + Program.i);
	}
	static void calcularAno () {
		double anacleto = 1.5;
		double felisberto = 1.1;
		
		while (anacleto > felisberto){
			felisberto = felisberto + 0.03;
			anacleto = anacleto + 0.02;
			Program.i = Program.i + 1;
		}
	}
}