using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    internal class Exercicio1
    {
        static void Main(string[] args)
        {

            int n, soma = 0, somaDp = 0, somaDs = 0;
            Console.WriteLine("Informe um valor para domínio da matriz: ");
            n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n,n];
            Random x = new Random();

            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                soma = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = x.Next(1, 10);
                    soma += matriz[i, j];

                    if (i == j)
                    {
                        somaDp += matriz[i, j];
                    }

                    Console.WriteLine($"Número na posição {"[" + i + "]" + "," + "[" + j + "]"}: " + matriz[i, j]);
                }
                Console.WriteLine();
                Console.WriteLine($"A soma da {i + 1}º linha é: " + soma);
                Console.WriteLine();
            }
            
            Console.WriteLine("A soma da diagonal principal é: " + somaDp);
            Console.WriteLine();

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                soma = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    soma += matriz[i, j];
                    Console.WriteLine(matriz[i,j]);
                }
                Console.WriteLine();
                Console.WriteLine($"A soma da {j + 1}º coluna é: " + soma);
                Console.WriteLine();
            }

            for (int i = 0, j = (n-1); i < matriz.GetLength(0); i++, j--)
            {
               somaDs += matriz[i,j];
               Console.WriteLine(matriz[i, j]);
            }
            Console.WriteLine();
            Console.WriteLine($"A soma da diagonal secundária é: " + somaDs);
           
            Console.ReadLine();
        }
    }
}
