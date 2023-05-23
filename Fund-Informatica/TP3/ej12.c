#include <stdio.h>
#include <stdlib.h>


int main(){

    int suma;
    suma=0;
    
    for (int i = 0; i <= 100; i+=10){
        suma=suma+i;
    }
    printf("La suma daria: %d",suma);

    return 0;
}