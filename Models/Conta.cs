using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOPOO.Models
{
    public abstract class Conta
    {
        protected double saldo;

        public abstract void Creditar(double valor);
        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é de: R$ " + saldo);
        }
    }
}

/*
    E possivel selar um calsse para que outra classe não recebam herança dela, para isso basta usar a palavra reservada sealed, isto serve tanto para classes 
    quanto para metodos, por exemplo:

    public sealed class Conta
    {
        protected double saldo;

        public virtual void Creditar(double valor)
        {
            saldo += valor;
        }
        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é de: R$ " + saldo);
        }
    }

    Neste caso nenhuma outra classe poderá herdar de conta e nem sobrescrever o metodo Creditar da classe conta. 


    Neste exemplo apenas o método foi selado inpendindo que outras classe sobrescrevam esse método, mas a classe em si ainda pode ser herdada.
    public  class Conta
    {
        protected double saldo;

        public virtual void Creditar(double valor)
        {
            saldo += valor;
        }
        public sealed void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é de: R$ " + saldo);
        }
    }

*/