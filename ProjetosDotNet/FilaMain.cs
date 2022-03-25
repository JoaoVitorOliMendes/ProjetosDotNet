using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDotNet
{
    internal class FilaMain
    {
        public static void filamain()
        {
            Fila filaPedidos = new Fila(100);
            Fila filaPagamentos = new Fila(100);
            Fila filaEncomendas = new Fila(100);
            int count = 0;

            string entrada = "";

            while (entrada != "5")
            {
                Console.WriteLine("1 - Inserção de cliente na fila de pedidos " + '\n' +
                    "2 - Remoção de cliente da fila de pedidos " + '\n' +
                    "3 - Remoção de cliente da fila de pagamentos " + '\n' +
                    "4 - Remoção de cliente da fila de encomendas " + '\n' +
                    "5 - Sair "
                );
                entrada = Console.ReadLine();
                switch (entrada)
                {
                    case "1":
                        filaPedidos.Enfileirar(count);
                        Console.WriteLine('\n' + "Cliente " + count + " entrou na fila de pedidos" + '\n');
                        count++;
                        break;
                    case "2":
                        if (!filaPedidos.Vazia())
                        {
                            int cliente = filaPedidos.Desenfileirar();
                            filaPagamentos.Enfileirar(cliente);
                            Console.WriteLine('\n' + "Cliente " + cliente + " saiu da fila de pedidos e entrou na fila de pagamentos" + '\n');
                        }else
                        {
                            Console.WriteLine('\n' + "Nenhum cliente na fila de pedidos" + '\n');
                        }
                        break;
                    case "3":
                        if (!filaPagamentos.Vazia())
                        {
                            int cliente = filaPagamentos.Desenfileirar();
                            filaEncomendas.Enfileirar(cliente);
                            Console.WriteLine('\n' + "Cliente " + cliente + " saiu da fila de pagamentos e entrou na fila de encomendas" + '\n');
                        }
                        else
                        {
                            Console.WriteLine('\n' + "Nenhum cliente na fila de pagamentos" + '\n');
                        }
                        break;
                    case "4":
                        if (!filaEncomendas.Vazia())
                        {
                            int cliente = filaEncomendas.Desenfileirar();
                            Console.WriteLine('\n' + "Cliente " + cliente + " saiu do restaurante Dona Tita" + '\n');
                        }
                        else
                        {
                            Console.WriteLine('\n' + "Nenhum cliente na fila de encomendas" + '\n');
                        }
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine('\n' + "DIGITE UM NUMERO DE 1 A 5" + '\n');
                        break;
                }
            }
        }

    }
}
