#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define TAM 15

int main(){

    int vector[TAM];
    int *pvector = &vector[0];

    srand(time(NULL));

    for (int i = 0; i < TAM; i++){
        vector[i] = rand() % 101;
    }

    for (int i = 0; i < TAM; i++){
        printf("Posicion %d : ", i);
        printf("Direccion de memoria : %p - ", pvector);
        printf("Valor : %d\n", *pvector);
        pvector++;
    }

    return 0;
}