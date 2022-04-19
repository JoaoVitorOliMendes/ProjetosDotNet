using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDotNet
{
    internal class ListaEncadeadaMain
    {
        public static void listaEncadeadaMain()
        {
            Lista lista = new Lista();
            int input = 0;

            while(input != 4)
            {

                Console.WriteLine(
                    "1) Inserir \n" +
                    "2) Pesquisar \n" +
                    "3) Imprimir Lista \n" +
                    "4) Sair \n");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Insira um numero");
                        lista.Inserir(new NoLista(int.Parse(Console.ReadLine())));
                        break;
                    case 2:
                        Console.WriteLine("Pesquise um numero");
                        NoLista resultadoPesquisa = lista.Pesquisar(int.Parse(Console.ReadLine()));
                        if(resultadoPesquisa == null)
                        {
                            Console.WriteLine("Não existe");
                        }else
                        {
                            Console.WriteLine(resultadoPesquisa.chave + " encontrado!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Imprimindo a Lista: \n");
                        lista.Imprimir();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Sair");
                        break;
                }
            }
        }
    }
}
