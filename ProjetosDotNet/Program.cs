using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            // Atividades Práticas
            Console.WriteLine("MENU BUNITÂO: \n" +
                "Exercício Pilha: [ 1 ] \n" +
                "Exercícío Fila: [ 2 ] \n" +
                "Exercícío Lista Encadeada: [ 3 ] \n" +
                "MaxMin: [ 4 ] \n" +
                "Saída: [ 5 ] \n");

            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    PilhaMain.pilhamain();
                    break;
                case 2:
                    FilaMain.filamain();
                    break;
                case 3:
                    ListaEncadeadaMain.listaEncadeadaMain();
                    break;
                case 4:
                    MaxMinMain.maxMinMain();
                    break;
            }

            Console.ReadKey();
        }
    }
}
