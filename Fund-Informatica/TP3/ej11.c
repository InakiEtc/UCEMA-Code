#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){

    int suma;
    suma=0;
    
    for (int i = 13; i < 26; i++){
        suma=suma+pow(i,2);
    }
    printf("La suma de los cuadrados de nums del 13 al 25 es: %d",suma);

    return 0;
}