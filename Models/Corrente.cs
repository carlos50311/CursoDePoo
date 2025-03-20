using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            saldo += valor;

            Console.WriteLine($"Foi creditado o valor de R$ {valor} na sua conta corrente");
        }
    }
}