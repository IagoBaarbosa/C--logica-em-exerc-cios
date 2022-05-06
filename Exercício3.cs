/*
 * Disciplina : [Linguagem e Lógica de Programação]
 * Professor : Yuri Titi
 * Descrição : Fazer um algoritmo que:
 * o Leia um número indeterminado de linhas
 * contendo cada uma a idade de um indivíduo.
 * o A última linha que não entrará nos cálculos,
 * contém o valor da idade igual a zero.
 * o Calcule e escreva a idade média deste grupo
 * de indivíduos.
 * o Escreva também a maior idade e a menor
 * Autor(a) : Iago Barbosa
 * Data atual : 24/03/2022
 */

using System;
					
public class Program
{
	public static void Main()
	{
		int [] idade = new int [5];
		
		alocarIdade(idade);
		idadeMedia(idade);
		maiorIdade(idade);
		menorIdade(idade);
	}
	static void alocarIdade(int[] idade){
		for (int i = 0; i < 5; i++){
			Console.WriteLine("Digite uma idade");
			idade[i] = Convert.ToInt32(Console.ReadLine());
		}
	}
	static void idadeMedia(int[] idade){
		int somaElementos = 0;
		for(int x =0; x<5; x++){
			somaElementos += idade[x];	
		}
		double soma = somaElementos;
		double media = soma / 5.0;
		Console.WriteLine("A media das idades e :" + media);
	}
	static void maiorIdade(int[] idade){
		int maiorId = 0;
		for(int j = 0; j < 5; j++){
			if(idade[j] > maiorId){
				maiorId = idade[j];	
			}
		}
		Console.WriteLine("");
		Console.WriteLine("Maior idade e: " + maiorId);
	}
	static void menorIdade(int[] idade){
		int menorId = idade[0];
		for(int k = 0; k <5; k++){
			if(idade[k] < menorId){
				menorId = idade[k];	
			}
		}
		Console.WriteLine("Menor idade e: " + menorId);
	}
}