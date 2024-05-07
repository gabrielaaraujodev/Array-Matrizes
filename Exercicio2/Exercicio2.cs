using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Exercicio2
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[10, 10];
            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        matriz[i, j] = 2 * i + 7 * j - 2;
                    } else if (i == j)
                    {
                        matriz[i, j] = 3 * Math.Pow(i, 2) - 1;
                    } else
                    {
                        matriz[i, j] = 4*Math.Pow(i, 3) - 5*Math.Pow(j, 2) + 1;
                    }

                    Console.Write(matriz[i, j] + "\t");
                }
               Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
