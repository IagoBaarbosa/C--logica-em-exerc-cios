/*
 * Disciplina : [Linguagem e Lógica de Programação]
 * Professor : Yuri Titi
 * Descrição : Número primo é aquele que só é divisível
 * por ele mesmo e pela unidade. Fazer um
 * algoritmo que determine e escreva os
 * números primos compreendidos entre um
 * intervalo fornecido pelo usuário.
 * 
 * Autor(a) : Iago Barbosa
 * Data atual : 24/03/2022
 */

using System;
public class Program
{
    public static int numeroA = 0;
    public static int numeroB = 0;
    public static void Main()
    {
        Console.WriteLine("Escreva um valor INICIAL: ");
        Program.numeroA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escreva um valor FINAL, obrigatorio ser maior que o INICIAL: ");
        Program.numeroB = Convert.ToInt32(Console.ReadLine());

        if (Program.numeroA > Program.numeroB)
        {
            Console.WriteLine("!! ERRRO !!");
        }

        Console.WriteLine("No intervalo fornecido pelo USUARIO os numeros primos entre eles sao: ");
        for (int i = Program.numeroA; i < Program.numeroB; i++){
        
            if (numeroEprimo(i)){
            
                Console.WriteLine("O numero " + i + "e primo? " + numeroEprimo(i));
            }
        }
        public static bool numeroEprimo(int valor){
       
            for (int j = 2; j < valor;)
            {
                return false;
            }
            return true;
        }
    }
}