using System;

namespace _13abril2021_1
{
    public class Nodo
    {
        public int dato { get; set; }
        public Nodo sgte { get; set; }

        public Nodo(int dato){
            this.dato = dato;
            sgte = null;            
        }
    }
}
