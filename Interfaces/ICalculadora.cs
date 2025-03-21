using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int a, int b);
        int Somar(int a, int b, int c);
        int Subtrair(int a, int b);
        int Dividir(int a, int b);
        int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
}

/*
    Interfaces são como classes abstratas mais com alguma diferenças, elas não tem a implementação dos métodos, mas apenas a 
    assinatura deles. A interface é um contrato que a classe que a implementa deve seguir.

    E também uma classe pode implementar várias inteerfaces, mas não pode herdar de várias classes.

    Outra diferença é que a  interface não pode ter atributos, apenas métodos. E ela não e herdada e sim implementada.

    
*/