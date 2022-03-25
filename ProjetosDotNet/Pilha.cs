using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDotNet
{
    class Pilha
    {
        private int[] vet;
        private int topo;

        public Pilha(int tam)
        {
            vet = new int[tam];
            topo = 0;
        }

        public void Empilhar(int x)
        {
            vet[topo] = x;
            topo++;
        }

        public int Desempilhar()
        {
            topo--;
            return (vet[topo]);
        }

        public bool Vazia()
        {
            return (topo == 0);
        }

        public bool Cheia()
        {
            return (topo == vet.Length);
        }

    }
}
