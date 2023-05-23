#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){

    int suma;
    suma=0;
    
    for (int i = 1; i < 11; i++){
        suma=suma+pow(i,2);
    }
    printf("La suma de los cuadrados de nums del 1 al 10 es: %d",suma);

    return 0;
}