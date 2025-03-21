using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EXEMPLOPOO.Interfaces;

namespace EXEMPLOPOO.Models
{
    public class Calculadora : ICalculadora
    {
        public  int Somar(int a, int b)
        {
            return a + b;
        }

        public  int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

        public  int Dividir(int a, int b)
        {
            if(b == 0 || a == 0){
                throw new Exception("Não é possivel dividir por zero");
            }

            return a / b; 
        }

        public  int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}