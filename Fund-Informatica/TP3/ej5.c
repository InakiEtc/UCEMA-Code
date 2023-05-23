#include <stdio.h>
#include <stdlib.h>

int main(){

    printf("Tabla del 5: \n");
    printf("------------ \n");

    for (int i = 0; i < 11; i++){
        printf("5 x %d = %d \n",i,5*i);
    }

    return 0;
}