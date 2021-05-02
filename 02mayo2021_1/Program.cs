using System;

namespace _02mayo2021_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Probar_Lista();            
        }

        public static void Probar_Lista() {
            Lista lista = new Lista();

            lista.Adicionar(20);
            lista.Adicionar(5);
            lista.Adicionar(9);
            lista.Adicionar(10);

            lista.Mostrar(); //20,5,9,10
        }
    }
}
