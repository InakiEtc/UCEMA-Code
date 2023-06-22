#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define SIZE 10

int main(){

    int vector[SIZE];
    int *pVector = &vector[0];
    int *pMayor = &vector[0];
    int posMayor = 0;

    srand(time(NULL));

    for(int i = 0; i < SIZE; i++){
        vector[i] = rand() % 100;
        printf("%d ", vector[i]);
    }

    for(int i = 0; i < SIZE; i++){
        if(*pVector > *pMayor){
            pMayor = pVector;
            posMayor = i;
        }
        pVector++;
    }

    printf("\nEl mayor valor es: %d\n", *pMayor);
    printf("Se encuentra en la posicion %d\n", posMayor);
    printf("Se encuentra en la direccion de memoria %p\n", pMayor);

    return 0;
}

