using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Channels;

namespace ControledeContas
{
    public class Contas
    {
        public Contas(long numero, Cliente titular, decimal saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public long Numero { get; private set; }
        public decimal Saldo { get; set; }
        public decimal Valor { get; set; }
        public Cliente Titular { get; set; }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public void PerguntarAdicionarSaldo()
        {
            Console.Write("Deseja adicionar saldo à conta? (S/N): ");
            string resposta = Console.ReadLine().Trim().ToUpper();

            if (resposta == "S")
            {
                Console.Write("Digite o valor a ser adicionado: ");
                decimal valor = decimal.Parse(Console.ReadLine());
                Depositar(valor);
                Console.WriteLine($"Saldo atualizado: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("Operação de depósito cancelada.");
            }
        }
    }
}