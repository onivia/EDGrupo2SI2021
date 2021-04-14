using System;

namespace _13abril2021_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            Nodo nodo = null;

            nodo = new Nodo(15);
            lista.Adicionar(nodo);
            nodo = new Nodo(7);
            lista.Adicionar(nodo);
            nodo = new Nodo(20);
            lista.Adicionar(nodo);
            nodo = new Nodo(3);
            lista.Adicionar(nodo);

            lista.Mostrar();
        }
    }
}
