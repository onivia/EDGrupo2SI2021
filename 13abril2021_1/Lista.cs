using System;

namespace _13abril2021_1
{
    public class Lista
    {
        public Nodo p { get; set; }
        public Nodo u { get; set; }
        public int tamano { get; set; }

        public Lista(){
            p = null;
            u = null;
            tamano = 0;
        }

        public bool estaVacia() {
            return (p == null && u == null);
        }

        public void Adicionar(Nodo nodo) {
            /*
            Si esta vacia (‘p’ y ‘u’ apuntaran a null):
                ‘p’ y ‘u’ apuntaran a ‘nodo’
            Sino esta vacia:
                ‘u.sgte’ apuntara a ‘nodo’
                ‘u’ apuntara a ‘nodo’
            tamano+=1
            */
            if(estaVacia()) {
                p = nodo;
                u = nodo;
            }
            else {
                u.sgte = nodo;
                u = nodo;
            }
            tamano+=1;
        }

        public void Mostrar() {
            /*
            Posicionar a ‘nodoAux’ a donde apunta ‘p’
            Mientras (no se alcance a ‘tamano’):
                Mostrar ‘nodoAux.dato’
                Posicione a ‘nodoAux’ en ‘nodoAux.sgte’
                Incremente a ‘i’
            */
            Nodo nodoAux = null;
            int i = 0;

            nodoAux = p;
            while(i < tamano) {
                Console.WriteLine(nodoAux.dato);
                nodoAux = nodoAux.sgte;
                i+=1;
            }
        }
    
        public void insertarPrimero(Nodo nodo) {

        }

        private void removerPrimero() {
            
        }

        public Nodo obteneryRemoverPrimero() {
            /*
            1. Obtener COPIA del 1er nodo
            2. Remover 1er nodo
            3. Retornar la copia del 1er nodo
            */            
        }
    }
}
