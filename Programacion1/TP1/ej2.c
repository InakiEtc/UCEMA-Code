#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(){

    int *vector;
    int cont;

    srand(time(NULL));

    vector = (int*) calloc(500,sizeof(int));

    for(int i=0; i<500; i++){
        vector[i] = rand()%11;
        printf("pos: %d / val: %d \n",i,vector[i]);
    }

    printf("\n");

    for(int i=0; i<=10; i++){
        cont = 0;
        for(int j=0; j<500; j++){
            if(i == vector[j]){
                cont++;
            }
        }
        printf("El numero %d se repite %d veces\n", i, cont);
    }

    free(vector);

    return 0;
}