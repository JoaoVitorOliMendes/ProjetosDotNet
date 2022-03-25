using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDotNet
{
    internal class PreencheMatriz
    {
        public static void preencheMatriz()
        {
            int[,] matriz = new int[5, 5];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if(i == j) matriz[i, j] = 0;

                    if(j > i) matriz[i,j] = 2;

                    if (j < i) matriz[i, j] = 1;

                    Console.Write(matriz[i, j] + " ");
                }
                Console.Write("\n");
            }

        }
    }
}
