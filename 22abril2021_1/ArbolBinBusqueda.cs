using System;

namespace _22abril2021_1
{
    public class ArbolBinBusqueda
    {
        private Nodo raiz;

        public ArbolBinBusqueda()
        {
            raiz = null;            
        }

        public bool estaVacio() {
            return (raiz==null);
        }

        public void Insertar(int llave, string dato) {
            Nodo nodo = null;
            Nodo nodoAux = null;

            //Este es el nodo a ser insertado
            nodo = new Nodo(llave, dato);

            if(estaVacio()) {
                raiz = nodo;
            }
            else {
                nodoAux = raiz;
                while(true) {
                    //TODO: Complete aqui

                }
            }
        }
    }
}
