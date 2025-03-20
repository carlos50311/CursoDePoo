using System.ComponentModel.DataAnnotations;
using EXEMPLOPOO.Models;

Aluno a1 = new()
{
    Nome = "joão",
    Idade = 20,
    Email = "joao33@gmail.com",
    Nota = 10
};
a1.Apresentar();

Console.WriteLine();

Professor pr1 = new()
{
    Nome = "Caio",
    Idade = 30,
    Email = "caio34@gmail.com",
    Salario = 10000

};
pr1.Apresentar();





































// ContaCorrente cc1 = new ContaCorrente(123, 1000);

// cc1.Sacar(500);
// cc1.ExibirSaldo();




































// Pessoa p1 = new Pessoa();