using ControledeContas;
using System;

List<Cliente> clientes = new List<Cliente>();

Cliente cliente1 = new Cliente("João da Silva", 1980, "12345678901");
Cliente cliente2 = new Cliente("Maria Souza", 1995, "98765432109");

Contas conta1 = new Contas(123456, cliente1, 1000.0M);
Contas conta2 = new Contas(789012, cliente2, 500.0M);

clientes.Add(cliente1);
clientes.Add(cliente2);

foreach (var cliente in clientes)
{
    Console.WriteLine($"Nome do titular: {cliente.Nome}");
    Console.WriteLine($"CPF do titular: {cliente.Cpf}");
    Console.WriteLine($"Saldo atual da conta: {conta1.Saldo:C}");

    conta1.PerguntarAdicionarSaldo();
    Console.WriteLine(); 
}

Console.ReadLine();