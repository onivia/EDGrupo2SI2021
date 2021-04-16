using System;

namespace _13abril2021_1
{
    public class Cola: Lista
    {
        public Cola() {}

        public void Encolar(Nodo nodo) {
            Adicionar(nodo);
        }

        public Nodo Desencolar() {
            Nodo nodo = null;

            nodo = obteneryRemoverPrimero();

            return nodo;
        }
    }    
}
