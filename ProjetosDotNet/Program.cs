using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDotNet
{
    internal class Program
    {

        static Pilha pilha = new Pilha(100);

        static void Main(string[] args)
        {
            string entrada = "";

            do
            {
                if(entrada != "")
                {
                    switch (entrada)
                    {
                        case "+": 
                            add();
                            break;
                        case "-":
                            subtract();
                            break;
                        case "*":
                            multiply();
                            break;
                        case "/":
                            divide();
                            break;
                            default:
                                int numero = int.Parse(entrada);
                                pilha.Empilhar(numero);
                            break;

                    }
                }
                Console.Write("Digite um valor ou operador (s para sair): ");
                entrada = Console.ReadLine();
            } while (entrada != "s");
        }

        static void add()
        {
            int val1, val2;
            if (!pilha.Vazia())
            {
                val1 = pilha.Desempilhar();
                if (!pilha.Vazia())
                {
                    val2 = pilha.Desempilhar();
                    int soma = val1 + val2;
                    pilha.Empilhar(soma);
                    Console.WriteLine(soma);
                }
                else
                    Console.WriteLine("Números inuficientes para completar a operação");
                pilha.Empilhar(val1);
            }
            else
                Console.WriteLine("Números inuficientes para completar a operação");

        }

        static void subtract()
        {
            int val1, val2;
            if (!pilha.Vazia())
            {

                val1 = pilha.Desempilhar();
                if (!pilha.Vazia())
                {
                    val2 = pilha.Desempilhar();
                    int soma = val1 - val2;
                    pilha.Empilhar(soma);
                    Console.WriteLine(soma);
                }
                else
                    Console.WriteLine("Números inuficientes para completar a operação");
                pilha.Empilhar(val1);
            }
            else
                Console.WriteLine("Números inuficientes para completar a operação");
        }

        static void multiply()
        {
            int val1, val2;
            if (!pilha.Vazia())
            {
                val1 = pilha.Desempilhar();
                if (!pilha.Vazia())
                {
                    val2 = pilha.Desempilhar();
                    int soma = val1 * val2;
                    pilha.Empilhar(soma);
                    Console.WriteLine(soma);
                }
                else
                    Console.WriteLine("Números inuficientes para completar a operação");
                pilha.Empilhar(val1);
            }
            else
                Console.WriteLine("Números inuficientes para completar a operação");
        }

        static void divide()
        {
            int val1, val2;
            if (!pilha.Vazia())
            {
                val1 = pilha.Desempilhar();
                if (!pilha.Vazia())
                {
                    val2 = pilha.Desempilhar();
                    int soma = val1 / val2;
                    pilha.Empilhar(soma);
                    Console.WriteLine(soma);
                }
                else
                    Console.WriteLine("Números inuficientes para completar a operação");
                pilha.Empilhar(val1);
            }
            else
                Console.WriteLine("Números inuficientes para completar a operação");
        }
    }
}
