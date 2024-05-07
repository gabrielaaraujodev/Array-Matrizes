using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Exercicio4
    {
        static void Main(string[] args)
        {
            int n = 6;
            int[,] matriz = new int[n, n];
            int[] somL = new int[n];
            int[] somC = new int[n];
            int somaDp = 0, somaDs = 0;
            Random x = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {              
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = x.Next(10, 60);
                    somL[i] += matriz[i, j];

                    if (i == j)
                    {
                        somaDp += matriz[i,j];
                    }

                }
            }

            for (int i = 0,j = (n-1); i < matriz.GetLength(0); i++, j--)
            {
                somaDs += matriz[i,j];
            }

            for (int j = 0; j < matriz.GetLength(1);j++)
            {
                for(int i = 0; i < matriz.GetLength(0); i++)
                {
                    somC[j] += matriz[i,j];
                }
            }
            
            for(int i = 0; i < somL.Length; i++)
            {
                if (somL[i] == somC[i] && somaDp == somaDs && somL[i] == somaDp)
                {
                    Console.WriteLine("É um quadrado mágico !");
                } else
                {
                    Console.WriteLine("Não é um quadrado mágico !");
                }
            }

            Console.ReadLine();
        }
    }
}
