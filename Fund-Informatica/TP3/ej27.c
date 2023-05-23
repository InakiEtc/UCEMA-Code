#include <stdio.h>
#include <stdlib.h>

int main(){

    int num,par=0,impar=0;

    printf("Ingrese un numero, El 100 corta el prg: ");
    scanf("%d",&num);
    
    while (num != 100){
        if (num%2==0){
            par++;
        }else{
            impar++;
        }       

        printf("Ingrese un numero, El 100 corta el prg: ");
        scanf("%d",&num);
    } 

    printf("Ingreso %d numero/s impar/es \n",impar);
    printf("Ingreso %d numero/s par/es \n",par);
    return 0;
}