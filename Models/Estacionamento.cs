using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TESTE_ESTACIONAMENTO.Models
{
    public class Estacionamento
    {
        private decimal _PrecoInicial { get; set; }
        private decimal _PrecoPorHora { get; set; }
        public List<string> Veiculos { get; set; }
        
        public Estacionamento()
            {

            }
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
            {
                this._PrecoInicial = precoInicial;
                this._PrecoPorHora = precoPorHora;
            }

        public void adicionarVeiculo()
        {
            
            Console.WriteLine(" Digite a placa do veiculo :");
            string placa = Console.ReadLine();
            Veiculos.Add(placa);
        }

        public void removerVeiculo()
        {
            Console.WriteLine(" Digite a placa do Veículo que deseja Remover ");
            string placaRemover = Console.ReadLine();
            
            
            if (Veiculos.Any(x => x.ToUpper() == placaRemover.ToUpper()))
            {
                int qtdHoras = 0;
                decimal ValorTotal = 0;
                Console.WriteLine(" Informe Quantas horas o veículo ficou Estacionado ");
                qtdHoras = Convert.ToInt32(Console.ReadLine());

                ValorTotal = _PrecoInicial + _PrecoPorHora * qtdHoras;

                Veiculos.Remove(placaRemover);
                Console.WriteLine($" O Veículo de placa {placaRemover} Foi Removido Com Sucesso !");
                Console.WriteLine($" O Valor a pagar é : {ValorTotal}");

            }
            else
            {
                Console.WriteLine(" O Veículo não existe na lista ");
            }
        }

        public void ListarVeiculos()
        {
            for (int contador = 0; contador < Veiculos.Count; contador++)
            {
                Console.WriteLine(" VEÍCULOS ESTACIONADOS ");
                Console.WriteLine($" Veículo numero : {contador + 1} Placa : {Veiculos[contador]} ");
            }
        }
    }
}