using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOPOO.Models
{
    public class Computador 
    {
        public override string ToString()
        {
            return "Metodo ToString() sobrescrito";
        }
    }
}

/*
    A class Object e um classe herdada por todas as classes em C#. Basicamente, ela é a classe base de todas as classes em c#.

    Ele e automaticamente herdada ao cria uma nova classe em C#.

    Exemplo:
    public class Computador : Object 
    {
    
    Métodos que a classe Object possui:
    }

        Equals();
        
        ReferenceEquals();
       
        Equals();
       
        GetHashCode();
    
        GetType();
       
        string? ToString();
       
        MemberwiseClone();
    }

    Isso significa que ao estanciar uma classe ela já possuira esses metodos e prpopriedades.
}

*/