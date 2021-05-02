using System;

namespace _02mayo2021_1
{
    public class Nodo
    {
        public int dato; //this.dato
        public Nodo sgte;

        public Nodo(int dato) { //new Nodo(20);
            this.dato = dato;
            sgte = null;
        }
    }
}
