using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControledeContas
{
    public class Cliente
    {
        public Cliente(string nome, int nascimento, string cpf)
        {
            Nome = nome;
            Nascimento = nascimento;
            Cpf = cpf;
        }
        public string Nome { get; set; }
        public int Nascimento { get; set; }
        public string Cpf { get; set; }

        public string CpfDigitos()
        {
            if (Cpf.Length != 11)
            {
                return "O CPF deve conter 11 dígitos, digite novamente!";
            }
            return "CPF aceito";
        }

        public int CalculodeIdade()
        {
            int anoAtual = DateTime.Now.Year;
            return anoAtual - Nascimento;
        }
    }
}