/*  Disciplina   : [Linguagem e Lógica de Programação]
 Professor   : Yuri Titi
 Descrição   :   Determinar se um número é par ou ímpar e
                 positivo ou negativo

 Autor(a)    : Iago Barbosa
 Data atual  : 08/03/2022 */

using System;
					
public class Program
{
	public static void Main()
	{
		int numero = 0;
		
		Console.WriteLine(" Informe um valor inteiro:  ");
		numero = Convert.ToInt32(Console.ReadLine());
		parOuImpar(numero);
		positivoOuNegativo(numero);
	}
	static void parOuImpar(int n){
		if(n % 2 == 0){
			Console.WriteLine("O numero e par");
		}else{
			Console.WriteLine("O numero e impar");
		}
	}
	static void positivoOuNegativo(int n){
		if (n > 0 ){
			Console.WriteLine("O numero e positivo");
		}else{
		    Console.WriteLine("O numero e negativo");	
		}
	}
}