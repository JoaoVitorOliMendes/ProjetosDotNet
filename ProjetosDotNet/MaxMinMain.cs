using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDotNet
{
    internal class MaxMinMain
    {
        public static void maxMinMain()
        {
            Random rand = new Random();
            MaxMin maxMin = new MaxMin();
            int[] crescente = new int[1000];
            int[] decrescente = new int[1000];
            int[] aleatorio = new int[1000];
            int[][] modos = new int[3][];

            for(int i = 0;i < 3; i++)
            {

                for(int j = 0; j < crescente.Length; j++)
                {
                    if (i == 0)
                    {
                        crescente[j] = j;
                        modos[i] = crescente;
                    }else if(i == 1)
                    {
                        decrescente[j] = 1000 - j;
                        modos[i] = decrescente;
                    }else if(i == 2)
                    {
                        aleatorio[j] = rand.Next(0,1000);
                        modos[i] = aleatorio;
                    }
                }
                int ma1, me1;
                long count1;
                maxMin.MaxMin1(modos[i], out ma1, out me1, out count1);
                Console.WriteLine("MaxMin1: ");
                Console.WriteLine("Maior: " + ma1);
                Console.WriteLine("Menor: " + me1);
                Console.WriteLine("IFs: " + count1);
                Console.WriteLine("11111111111111111111111111111");
                Console.WriteLine("");
                int ma2, me2;
                long count2;
                maxMin.MaxMin2(modos[i], out ma2, out me2, out count2);
                Console.WriteLine("MaxMin2: ");
                Console.WriteLine("Maior: " + ma2);
                Console.WriteLine("Menor: " + me2);
                Console.WriteLine("IFs: " + count2);
                Console.WriteLine("222222222222222222222222222");
                Console.WriteLine("");
                int ma3, me3;
                long count3;
                maxMin.MaxMin3(modos[i], out ma3, out me3, out count3);
                Console.WriteLine("MaxMin3: ");
                Console.WriteLine("Maior: " + ma3);
                Console.WriteLine("Menor: " + me3);
                Console.WriteLine("IFs: " + count3);
                Console.WriteLine("333333333333333333333333333");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }

        }
    }
}
