using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Exercicio5
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];
            int cont = 0;

            Random rand = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rand.Next(1, 11);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for(int i = 0; i < matriz.GetLength(0); i++) 
            {
               for(int j = 0;j < i;j++)
                {
                    if (matriz[i, j] == 0)
                    {
                        cont++;
                    }
                    Console.WriteLine(matriz[i, j] + "\t");
                }
            }

            if (cont == 6) {
                Console.WriteLine("É uma Matriz Triângulo Superior !");
            } else
            {
                Console.WriteLine("Não é uma Matriz Triângulo Superior !");
            }

            Console.ReadLine();
        }
    }
}
