#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include "order.c"

#define tam 10

int main(){
    
    srand(time(NULL));
    int array[tam];
    for(int i = 0; i < tam; i++){
        array[i] = rand() % 100;
    }

    printf("Array desordenado: ");
    for(int i = 0; i < tam; i++){
        printf("%d ",array[i]);
    }

    
    printf("\nArray ordenado por metodo de Intercambio: ");
    exchange(array,tam);
    for(int i = 0; i < tam; i++){
        printf("%d ",array[i]);
    } 
    

    
    printf("\nArray ordenado por metodo de Insersion: ");
    insertion(array,tam);
    for(int i = 0; i < tam; i++){
        printf("%d ",array[i]);
    }
    

    
    printf("\nArray ordenado por metodo de Burbuja: ");
    bubble(array,tam);
    for(int i = 0; i < tam; i++){
        printf("%d ",array[i]);
    }
    

    printf("\nArray ordenado por metodo de Shell: ");
    shell(array,tam);
    for(int i = 0; i < tam; i++){
        printf("%d ",array[i]);
    }

    printf("\n");
    
    return 0;
}