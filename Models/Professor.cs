using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome, int idade) : base(nome, idade) { }

        public Professor() { }
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} sou professor do curso dio e meu salário é : {Salario}");
        }
    }
}