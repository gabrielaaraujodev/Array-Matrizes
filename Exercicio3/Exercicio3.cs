using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Exercicio3
    {
        static void Main(string[] args)
        {
            int option, multNumber, somaMatriz = 0, subtracaoMatriz = 0;


        do
        {

            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Soma Matricial");
            Console.WriteLine("2 - Subtração Matricial: ");
            Console.WriteLine("3 - Multiplicar a matriz por um número real: ");
            Console.WriteLine("4 - Sair");
            option = int.Parse(Console.ReadLine());


            if (option == 4)
            {
                Console.WriteLine("Saindo do programa !");
                break;
            }
            
            Console.WriteLine("Informe a dimensão da matriz: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Caso tenha selecionado a opção 3, escolha um número para multiplicar a matriz: ");
            multNumber = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[,] matriz = new int[n, n];
            int[,] multMatriz = new int[n, n];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Informe um valor para as posições: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    somaMatriz += matriz[i, j];
                    subtracaoMatriz -= matriz[i, j];
                    multMatriz[i, j] = matriz[i, j] * multNumber;
                }
            }

            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            switch (option)
        {
            case 1:
                Console.WriteLine("A soma de toda matriz é: " + somaMatriz);
                Console.WriteLine();
                break;
            case 2:
                Console.WriteLine("A subtração de toda matriz é: " + subtracaoMatriz);
                Console.WriteLine();
                break;
            case 3:
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.Write(multMatriz[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                break;     
        }    

        Console.WriteLine();
    } while (option != 4);

            

    Console.ReadLine();
        }
    }
}
