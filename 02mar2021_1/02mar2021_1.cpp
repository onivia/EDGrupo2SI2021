#include <iostream>
using namespace std;

bool cadenasIguales(char cadena1[], char cadena2[], int tamanoCadena1, int tamanoCadena2) {
/*
    1. Definir Variables
        resultado(bool), true/false las cadenas son iguales
        contIgualdad, llevar un conteo de ocurrencias.
    2. Validar si las cadenas tienen el mismo tamaño, Sisi
        3. Se recorrera cada posicion de las cadenas:
            4. Validar si las cadenas en esa posicion son iguales
                Sisi, se incrementa 'contIgualdad'
            5. Sino, Validar si el caracter en esa posicion de ambas cadenas es una letra, Sisi
                6. Validarsi el valor absoluto de la diferencia de sus valores es 32
                    Sisi, se incrementa 'contIgualdad'
        7. Validar si son iguales 'contIgualdad' y el 'tamanoCadena1'
*/
   //1.
   bool resultado = false;
   int contIgualdad = 0;

   //2.
   if (tamanoCadena1==tamanoCadena2) {
       //3.
       for (int i = 0; i<tamanoCadena1; i++)
       {
           //4.
           if(cadena1[i]==cadena2[i]) {
               contIgualdad+=1;
           }
           //5.
           else if((cadena1[i]>=65&&cadena1[i]<=90) || (cadena1[i]>=97&&cadena1[i]<=122) &&
                (cadena2[i]>=65&&cadena2[i]<=90) || (cadena2[i]>=97&&cadena2[i]<=122)) {
                    //6.
                    if(abs(cadena1[i]-cadena2[i])==32) {
                        contIgualdad+=1;
                    }
           }
       } //for
       //7.
       if(contIgualdad==tamanoCadena1) {
           resultado = true;
       }       
   }

   return resultado;
}

int main() {
    char cadena1[32]="";
    char cadena2[32]="";
    int tamanoCadena1 = 0;
    int tamanoCadena2 = 0;
    bool sonIguales = false;

    cout<<"Entre cadena1: "<<endl;
    cin.getline(cadena1,32);
    cout<<"Entre cadena2: "<<endl;
    cin.getline(cadena2,32);

    tamanoCadena1 = sizeof(cadena1)/sizeof(cadena1[0]);
    tamanoCadena2 = sizeof(cadena2)/sizeof(cadena2[0]);

    sonIguales = cadenasIguales(cadena1, cadena2, tamanoCadena1, tamanoCadena2);

    cout<<boolalpha<<"son Iguales?: "<<sonIguales<<endl;

    return 0;
}