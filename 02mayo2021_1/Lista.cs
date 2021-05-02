using System;

namespace _02mayo2021_1
{
    public class Lista
    {
        public Nodo p;
        public Nodo u;
        public int tamano;

        public Lista(){ //new Lista();
            p = null;
            u = null;
            tamano = 0;
        }

        public bool estaVacia() {
            if(p == null && u == null) //tamano == 0
                return true;
            else 
                return false;
        }
        
        //Permite adicionar, es decir como nuevo ultimo un nodo
        public void Adicionar(int dato) {
            /*
                1. declarar variables:
                    nodo
                2. crear un 'nodo' a partir del 'dato'
                3. Si la lista esta vacia:
                        p apunte a 'nodo'
                        u apunte a 'nodo'
                4. Si no esta vacia la lista:                        
                        u.sgte apunte a 'nodo'
                        u apunte a 'nodo'                        
                5. incrementamos en 1 'tamano'
            */
            //1.
            Nodo nodo = null;
            //2.
            nodo = new Nodo(dato);
            //3.
            if(estaVacia()) {
                p = nodo;
                u = nodo;
            }
            //4.
            else { //no esta vacia
                u.sgte = nodo; //enlazando el ultimo nodo con el nuevo nodo
                u = nodo; //posicion a u en el nuevo ultimo nodo
            }
            //5.
            tamano += 1;
        }

        //Recorre cada nodo mostrar su dato, se decir mostrar desde el 1° elemento hasta el ultimo elemento los datos
        public void Mostrar() {
            /*
            1. Declarar variables:
                nodoAux
                i
            2. posicionar a nodoAux en el 1° nodo, es decir nodoAux apunte a 'p'
            3. inicializar a 'i' en 0
                While(i<tamano):
                    4. mostrar el dato de ese nodo, es decir con 'nodoAux.dato'
                    5. movemos a nodoAux al sgte nodo, es decir con 'nodoAux = nodoAux.sgte'
                    6. incremementamos a 'i'
            */
            //1.
            Nodo nodoAux = null;
            int i = 0;
            //2.
            nodoAux = p;
            //3.
            i = 0;
            while(i < tamano) {
                //4.
                Console.WriteLine($"{nodoAux.dato}");
                //5.
                nodoAux = nodoAux.sgte;
                //6.
                i+=1;
            }
        }
    }
}
