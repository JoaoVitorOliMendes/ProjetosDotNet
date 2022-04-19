using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDotNet
{
    internal class MaxMin
    {

        // Operação relevante: TESTES (if)
        // T(n) = 2n - 2
        public void MaxMin1(int[] vet, out int ma, out int me, out long count)
        {
            count = 0;
            ma = me = vet[0];
            for (int i = 1; i < vet.Length; i++)
            {
                if (vet[i] < me)
                {
                    me = vet[i];
                }
                count++;
                if (vet[i] > ma)
                {
                    ma = vet[i];
                }
                count++;
            }
        }

        // Melhor caso: T(n) = n - 1
        // Pior caso: T(n) = 2n - 2
        // Caso médio: T(n) = 3n/2 - 3/2
        public void MaxMin2(int[] vet, out int ma, out int me, out long count)
        {
            count = 0;
            ma = me = vet[0];
            for (int i = 1; i < vet.Length; i++)
            {
                count++;
                if (vet[i] < me)
                {
                    me = vet[i];
                }
                else
                {
                    count++;
                    if (vet[i] > ma)
                        ma = vet[i];
                }

            }
        }

        // T(n) = 3n/2 - 2
        public void MaxMin3(int[] vet, out int ma, out int me, out long count)
        {
            count = 0;
            count++;
            if (vet[0] < vet[1])
            {
                me = vet[0];
                ma = vet[1];
            }
            else
            {
                me = vet[1];
                ma = vet[0];
            }
            for (int i = 2; i < vet.Length; i += 2)
            {
                count++;
                if (vet[i] < vet[i + 1])
                {
                    count++;
                    if (vet[i] < me)
                    {
                        me = vet[i];
                    }
                    count++;
                    if (vet[i + 1] > ma)
                    {
                        ma = vet[i + 1];
                    }
                }
                else
                {
                    count++;
                    if (vet[i + 1] < me)
                    {
                        me = vet[i + 1];
                    }
                    count++;
                    if (vet[i] > ma)
                    {
                        ma = vet[i];
                    }
                }
            }
        }
    }
}
