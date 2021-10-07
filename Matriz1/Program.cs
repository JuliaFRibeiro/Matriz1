using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ordem da matriz quadrada: ");
            //declarando variavel
            int n = int.Parse(Console.ReadLine());

            //tamanho da matriz dada pelo usuario
            int[,] mat = new int[n, n];

            Console.Write("Digite os nu meros da matriz separando-os por um espaço: ");
            //loop linha
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                //loop coluna
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            //gera o resultado
            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            //formula da matriz
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    //condição
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            //gera o resultado
            Console.WriteLine("Negative numbers: " + count);

            Console.ReadKey();
        }
    }
}
