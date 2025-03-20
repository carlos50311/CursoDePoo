using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroDaConta, decimal saldoInicial)
        {
            NumeroDaConta = numeroDaConta;
            saldo = saldoInicial;
        }

        public int NumeroDaConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("O valor do saque e maior que o saldo disponivel");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("O Saldo da conta é: " + saldo);
        }
    }
}