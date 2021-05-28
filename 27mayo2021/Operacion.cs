using System;

namespace _27mayo2021
{
    public class Operacion
    {
        public Operacion(){}

        public static int sumar(int n1, int n2) {
            return (n1 + n2);
        }

        public static int dividir(int n1, int n2) {
            if(n2==0)
                throw new Exception("div by 0 no");
            
            return (n1/n2);
        }        
    }
}
