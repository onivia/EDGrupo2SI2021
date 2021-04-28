using System;

namespace _22abril2021_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Prueba_ArbolBinarioBusqueda();
        }

        public static void Prueba_ArbolBinarioBusqueda() {
            //TODO: haga aqui la prueba de Insercion en una instancia de tipo 'ArbolBinarioBusqueda'
            ArbolBinBusqueda arbol = new ArbolBinBusqueda();
            string dato = null;

            arbol.Insertar(6,"seis");
            arbol.Insertar(3,"tres");
            arbol.Insertar(9,"nueve");
            arbol.Insertar(2,"dos");
            arbol.Insertar(10,"diez");
            dato = arbol.Obtener(10);
            Console.WriteLine($"el dato es: {dato}");
        }
    }
}
