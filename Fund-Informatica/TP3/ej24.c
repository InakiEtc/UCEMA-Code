#include <stdio.h>
#include <stdlib.h>

int main(){

    int num,suma = 0;
    printf("Ingrese un numero, el 0 corta el prg: ");
    scanf("%d",&num);
    
    while (num!=0){
        suma += num;
        printf("Ingrese un numero, el 0 corta el prg: ");
        scanf("%d",&num);
    } 

    printf("La suma de todos los numeros es: %d",suma);
    return 0;
}