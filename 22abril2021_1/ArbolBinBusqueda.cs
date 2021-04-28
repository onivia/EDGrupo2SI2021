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
                    /*
                    While:
                        *Si 'nodo.llave'<'nA.llave':
                            *Si 'nA.izq'!=null:
                                nA = nA.izq
                            *SiNo
                                nA.izq = nodo
                                break
                        *SiNo 'nodo.llave'>'nA.llave':
                            *Si 'nA.der'!=null:
                                nA = nA.der
                            *SiNo
                                nA.der = nodo
                                break
                        *SiNo
                            lanzar excepcion, ya existe esa llave
                    */
                    if(nodo.llave < nodoAux.llave) {
                        if(nodoAux.izq!=null)
                            nodoAux = nodoAux.izq;
                        else {
                            nodoAux.izq = nodo;
                            break;
                        }
                    }
                    else if(nodo.llave > nodoAux.llave) {
                        if(nodoAux.der!=null)
                            nodoAux = nodoAux.der;
                        else {
                            nodoAux.der = nodo;
                            break;
                        }
                    }
                    else { //ya existe la llave
                        throw new Exception($"la llave: {nodo.llave} ya existe, no se permiten llaves repetidas.");
                    }
                }
            }
        }

        public string Obtener(int llave) {
            /*
            1. Declarar 'datoHallado' para retornar el dato
            2. Si el arbol 'no este vacio':
                3. posicionar a 'nA' en 'raiz'
                4. Mientras un cliclo infinito:
                    5. Si 'nA' es null rompemos el ciclo 'break'
                    6. Si 'llave'=='nA.llave', asigno 'datoHallado' con 'nA.dato' y rompo el ciclo
                    7. Si 'llave'<'nA.llave', muevo a 'nA' a su izq
                    8. Si 'llave'>'nA.llave', muevo a 'nA' a su der
                9. retorno a 'datoHallado'
            */
            string datoHallado = null;
            Nodo nodoAux = null;

            if(!estaVacio()) {
                nodoAux = raiz;
                while(true) {
                    if(nodoAux==null)
                        break;
                    
                    if(llave==nodoAux.llave) {
                        datoHallado = nodoAux.dato;
                        break;
                    }
                    else if(llave < nodoAux.llave)
                        nodoAux = nodoAux.izq;
                    else if(llave > nodoAux.llave)
                        nodoAux = nodoAux.der;
                }                
            }

            return datoHallado;
        }
    }
}
