#include <stdio.h>
#include <stdlib.h>

int main(){

    int *vector = (int*)calloc(10, sizeof(int));

    for(int i = 0; i < 10; i++){
        printf("%d, ", vector[i]);
    }

    printf("\n");

    for(int i = 0; i < 10; i++){
        printf("Ingrese un valor para las pos %d: ",i);
        scanf("%d", &vector[i]);
    }

    for(int i = 0; i < 10; i++){
        printf("%d, ", vector[i]);
    }

    printf("\n");
    
    vector = (int*)realloc(vector, 15*sizeof(int));

    for(int i = 10; i < 15; i++){
        printf("Ingrese un valor para las pos %d: ",i);
        scanf("%d", &vector[i]);
    }

    for(int i = 0; i < 15; i++){
        printf("%d, ", vector[i]);
    }

    free(vector);

    return 0;
}