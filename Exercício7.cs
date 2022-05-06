/*
 * Disciplina : [Linguagem e Lógica de Programação]
 * Professor : Yuri Titi
 * Descrição : Numa eleição existem três candidatos
 * identificados pelos números 1, 2 e 3. Faça um
 * algoritmo que compute o resultado de uma
 * eleição. Inicialmente o programa deve pedir o
 * número total de votantes. Em seguida, deve
 * pedir para cada votante votar (informando o
 * número do candidato) e ao final mostrar o
 * número de votos de cada candidato
 * 
 * Autor(a) : Iago Barbosa
 * Data atual : 24/03/2022
 */

using System;
							
public class Program
{
	public static int cand1 = 0;
	public static int cand2 = 0;
	public static int cand3 = 0;
	public static int cand4 = 0;
	public static int nulo = 0;
	
	public static void Main()
	{
		Console.WriteLine("Quantas pessoas iram votar? ");
		int numeroVotantes = Convert.ToInt32(Console.ReadLine());
		
		for(int i = 1; i <= numeroVotantes; i++){
			contadorCandidato(i);
				int votos = Convert.ToInt32(Console.ReadLine());
			contadorDeVotos(votos);
		}
		contagem(numeroVotantes);
	}
	static void contagem (int numeroVotantes){
		Console.WriteLine("O numero de votantes e de: " + numeroVotantes);
		Console.WriteLine("O candidato [1] recebeu: " + cand1 + " votos");
		Console.WriteLine("O candidato [2] recebeu: " + cand2 + " votos");
		Console.WriteLine("O candidato [3] recebeu: " + cand3 + " votos");
		Console.WriteLine("Houveram: " + nulo + " votos nulos");
	}
	
	static void contadorCandidato (int i){
		Console.WriteLine("Eleitor numero: " + i);
		Console.WriteLine("Digite o numero do seu candidato");
		Console.WriteLine("Digite [1] -  para candidato 01 ");
		Console.WriteLine("Digite [2] -  para candidato 02 ");
		Console.WriteLine("Digite [3] -  para candidato 03 ");
	}
	static void contadorDeVotos(int votos) {
		switch (votos) {
			case 1: 
				 Program.cand1 = Program.cand1 + 1;
                break;
            case 2:
                Program.cand2 = Program.cand2 + 1;
                break;
            case 3:
                Program.cand3 = Program.cand3 + 1;
                break;
            default:
                Program.nulo = Program.nulo + 1;
				break;
		}
	}
}