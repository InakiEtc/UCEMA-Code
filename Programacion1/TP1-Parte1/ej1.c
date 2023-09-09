#include <stdio.h>
#include <stdlib.h>

int main(){

    int *p = NULL;
    int mb=0;

    do{
        p = (int*) malloc(1000000);
        mb++;

    }while(p != NULL);

    printf("La PC tiene %d MB de memoria dinamica\n", mb);

    return 0;
}