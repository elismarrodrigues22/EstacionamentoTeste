// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using TESTE_ESTACIONAMENTO.Models;



bool controle = true;

decimal precoPorHora = 0;
decimal precoInicial = 0;

Estacionamento estacionamento1 = new Estacionamento(precoInicial, precoPorHora);

Console.WriteLine(" SISTEMA DE ESTACIONAMENTO ");
Console.WriteLine(" Digite o preço Inicial ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine(" Digite o preço por Hora ");
 precoPorHora = Convert.ToDecimal(Console.ReadLine());

estacionamento1.Veiculos = new List<string>();

while(controle == true)
    {
        
        Console.WriteLine( " ESCOLHA UMA OPÇÃO ");
        Console.WriteLine( " 1 - Cadastrar Veículo ");
        Console.WriteLine( " 2 -Listar Veículo ");
        Console.WriteLine( " 3 - Remover Veículo ");
        Console.WriteLine( " 4 - Encerrar ");
        int opcao = Convert.ToInt32(Console.ReadLine());

        switch(opcao)
            {
                case 1:                    
                    estacionamento1.adicionarVeiculo();
                break;

                case 2:
                    
                    estacionamento1.ListarVeiculos();
                    break;

                case 3:
                     
                     estacionamento1.removerVeiculo();
                     break;

                case 4:
                    controle = false;
                    break;

                default :
                    Console.WriteLine(" Opção inválida ");     
                    break;    
            }
            Console.WriteLine(" Pressione uma Tecla para Continuar...");
            Console.ReadLine();

    }

