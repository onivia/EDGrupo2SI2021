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
            /*
            Si esta vacia:
                ‘p’ y ‘u’ apuntaran a nodo
            Sino esta vacia:
                ‘nodo.sgte’ apuntara a ‘p’
                ‘p’ apuntara a nodo
            tamano++
            */
            if(estaVacia()) {
                p = nodo;
                u = nodo;
            }
            else {
                nodo.sgte = p;
                p = nodo;
            }
            tamano+=1;
        }

        private void removerPrimero() {
            /*
            NO esta vacia:
                tamano es 1
                    ‘p’ y ‘u’ apuntaran a null
                    Tamano es 0
                tamano > 1
                    ‘nA’ apuntara a ‘p’
                    ‘P’ apuntara al sgte nodo
                    ‘nA.sgte’ apuntara a null
                    ‘nA’ apuntara a null
                    tamano--
            */
            Nodo nododAux = null;

            if(!estaVacia()) {
                if(tamano==1) {
                    p = null;
                    u = null;
                    tamano = 0;
                }
                else { //tiene nodos
                    nododAux = p;
                    p = nododAux.sgte;
                    nododAux.sgte = null;
                    nododAux = null;
                    tamano-=1; //tamano--;
                }
            }
        }

        public Nodo obteneryRemoverPrimero() {
            /*
            1. Obtener COPIA del 1er nodo
            2. Remover 1er nodo
            3. Retornar la copia del 1er nodo
            */
            Nodo nodoCopia = null;

            if(!estaVacia()) {
                nodoCopia = new Nodo(p.dato);
                removerPrimero();                
            }

            return nodoCopia;
        }

        //Grupo 5, por favor mostrarnos con la debida explicacion (analisis e implementacion)
        //el funcionamiento de este metodo
        public bool Actualizar(int posicion, int dato) {

            return false; //debe retornarse un valor bool, donde 'true' indicara que efectivamente la posicion solicitada existe y se pudo hacer la actualizacion del dato, 'false' sino existia la posicion dada.
        }
    }
}
