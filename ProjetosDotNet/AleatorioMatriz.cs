using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDotNet
{
    internal class AleatorioMatriz
    {
        public static void preencheMatriz()
        {
            int[,] matriz = new int[6, 6];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = random.Next();

                    if (i == j) matriz[i, j] = 0;

                    if (j > i) matriz[i, j] = 2;

                    if (j < i) matriz[i, j] = 1;

                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine("\n");
            }

        }
    }
}
