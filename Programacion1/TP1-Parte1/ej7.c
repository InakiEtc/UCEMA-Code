#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>

int main(){

    int *vector,*vectorRedim;
    vector = (int*) calloc(10,sizeof(int));
    int aux;

    for(int i=0; i<10; i++){
        printf("Ingrese el numero para los pos: %d: ", i);
        scanf("%d", &vector[i]);
    }

    for(int i=0; i<10; i++){
        printf("pos: %d / val: %d \n",i,vector[i]);
    }

    printf("\n");
    vectorRedim = (int *)realloc(vector,20*sizeof(int));

    aux=9;
    for (int j=10; j<20; j++){
        vectorRedim[j] = vectorRedim[aux]*2;
        aux--;
    }

    for(int i=0; i<20; i++){
        printf("pos: %d / val: %d \n",i,vectorRedim[i]);
    }

    return 0;
}