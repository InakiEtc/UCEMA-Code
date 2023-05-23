#include <stdio.h>
#include <stdlib.h>

int main(){

    int num;
    printf("Ingrese un numero, el 0 corta el prg: ");
    scanf("%d",&num);
    
    while (num!=0){
        if(num%2==0){
            printf("El numero %d es par \n",num);
        }else{
            printf("El numero %d es impar \n",num);
        }

        printf("Ingrese un numero, el 0 corta el prg: ");
        scanf("%d",&num);
    } 

    return 0;
}