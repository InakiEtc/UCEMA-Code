#include <stdio.h>
#include <stdlib.h>

int main(){

    int num,nx,aux = 1;
    printf("Ingrese un numero: ");
    scanf("%d",&num);
    
    do {
        printf("\nTabla del %d: \n",aux);
        printf("------------ \n");
        nx=1;

        do{
            printf("%d x %d = %d \n",aux,nx,aux*nx);
            nx++;
        }while(nx != 11 );

        aux++;
    } while (aux!=num+1);

    return 0;
}