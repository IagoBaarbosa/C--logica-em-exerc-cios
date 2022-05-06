/*
 * Disciplina : [Linguagem e Lógica de Programação]
 * Professor : Yuri Titi
 * Descrição : Tem-se um conjunto de dados contendo a
 * altura e o sexo (masculino, feminino) de 50
 * pessoas. Fazer um algoritmo que calcule e
 * escreva:
 * o - a maior e a menor altura do grupo;
 * o - a média de altura das mulheres;
 * o - o número de homens;
 * 
 * Autor(a) : Iago Barbosa
 * Data atual : 24/03/2022
 */

using System;
					
public class Program
{
	public static int [] vetA = new int [4];
	public static int [] vetS = new int [4];
	public static int i = 0;
	public static double menor = 0;
	public static double maior = 0;
	public static double alturaToral = 0;
	public static int qtMulheres = 0;
	public static int nh = 0;
	
	public static void Main()
	{
		sexoAltura();
		menorAltura();
		maiorAltura();
		mediaAlturaMulheres();
		numeroDeHomens();
	}
	static void sexoAltura(){
		for (int i = 0; i < 4; i++){
			Console.WriteLine("Escolha o sexo da pessoa [1] Mulher  OU  [2] Homem ");
			Program.vetS[i] = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Digite a altura: ");
			Program.vetA[i] = Convert.ToInt32(Console.ReadLine());
		}
	}
	static void menorAltura(){
				Program.menor = Program.vetA[1];
		for(int i =0; i<4; i++){
			if(Program.vetA[i] < Program.menor){
				Program.menor = Program.vetA[i];
			}
		}
		Console.WriteLine("A menor altura e de: " + Program.menor);
	}
	static void maiorAltura(){
		for(int i = 0; i < 4; i++){
			if(Program.vetA[i] > Program.maior){
				Program.maior = Program.vetA[i];	
			}
		}
		Console.WriteLine("A maior altura e de: "+ Program.maior);
	}
	static void mediaAlturaMulheres(){
		for(int i =0; i < 4; i++){
			if ( Program.vetS[i] == 1){
				Program.qtMulheres = Program.qtMulheres + 1;
				Program.alturaToral = Program.vetA[i];
			}
		}
		Console.WriteLine("A media das altura das mulheres e de: "+ (Program.alturaToral / Program.qtMulheres));
	}
	static void numeroDeHomens(){
		for(int i = 0; i < 4; i++){
			if(Program.vetS[i] == 2){
				Program.nh = Program.nh + 1;	
			}
		}
		Console.WriteLine("O numero de homens e de: " + Program.nh);
	}
}