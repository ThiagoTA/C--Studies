using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor das linhas e das colunas: ");
            Console.Write("Linha: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Coluna: ");
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            Console.WriteLine("\nDigite os números das linhas");
            for (int i = 0; i < M; i++)
            {
                string[] values = Console.ReadLine().Split();

                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("\nEscolha um número da matriz: ");
            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] == X)
                    {
                        Console.Write("\nPosition: " + i + ", " + j + ":");

                        if (j > 0) { 
                            Console.Write("\nLeft: " + mat[i, j - 1]);
                        }

                        if (j < N - 1) { 
                            Console.Write("\nRight: " + mat[i, j + 1]);
                        }

                        if (i > 0) { 
                            Console.Write("\nUp: " + mat[i - 1, j]);
                        }

                        if (i < M - 1) {
                            Console.Write("\nDown: " + mat[i + 1, j]);
                        }
                    }   
                }
            }
        }
    }
}
