using System;

namespace _13abril2021_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Prueba_Lista();
            //Prueba_Cola();            
        }

        private static void Prueba_Lista() {
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

            lista.insertarPrimero(new Nodo(9));
            nodo = lista.obteneryRemoverPrimero();
            nodo = lista.obteneryRemoverPrimero();

            Console.WriteLine($"el dato del 1° nodo es: {nodo.dato}");
            lista.Mostrar();
        }
    
        private static void Prueba_Cola() {
            Cola cola = new Cola();
            Nodo nodo = null;

            nodo = new Nodo(20);
            cola.Encolar(nodo);
            nodo = new Nodo(5);
            cola.Encolar(nodo);
            nodo = new Nodo(3);
            cola.Encolar(nodo);

            cola.Mostrar();

            /*
            nodo = cola.Desencolar();
            cola.Mostrar(); //5, 3
            nodo = cola.Desencolar();
            cola.Mostrar(); //3
            nodo = cola.Desencolar();
            cola.Mostrar(); //no mostrara nada mas
            */

            /*
            nodo = cola.Desencolar();
            Console.WriteLine(nodo.dato); //20
            nodo = cola.Desencolar();
            Console.WriteLine(nodo.dato); //5
            nodo = cola.Desencolar();
            Console.WriteLine(nodo.dato); //3
            nodo = cola.Desencolar();
            Console.WriteLine(nodo.dato); //ERROR
            */
        }
    }
}
