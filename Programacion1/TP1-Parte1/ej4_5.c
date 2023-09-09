#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>
#include "order.h"

int main(){

    srand(time(NULL));

    int *vector,*vectorRedim;
    int cont=0;
    vector = (int *)calloc(20,sizeof(int));

    for(int i=0; i<20; i++){
        vector[i] = rand() % 6;
        printf("pos: %d / val: %d \n",i,vector[i]);
    }

    printf("\n");

    for(int j=0; j<20; j++){
        for(int k=j+1; k<20; k++){
            if(vector[j] == vector[k]){
                vector[k] = -1;
            }
        }
        if (vector[j] != -1) {
            vector[cont] = vector[j];
            cont++;
        }
    }
    
    vectorRedim = (int *)realloc(vector,cont*sizeof(int));
    shell(vectorRedim,cont);

    for(int i=0; i<cont; i++){
        printf("pos: %d / val: %d \n",i,vectorRedim[i]);
    }

    free(vector);
    free(vectorRedim);

    return 0;
}
