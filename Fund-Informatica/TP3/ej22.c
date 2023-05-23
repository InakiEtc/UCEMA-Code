#include <stdio.h>
#include <stdlib.h>

int main(){

    int num,may = 0;
    printf("Ingrese un numero, el 0 corta el prg: ");
    scanf("%d",&num);
    
    while (num!=0){
        if(num > may){
            may = num;
        }
        
        printf("Ingrese un numero, el 0 corta el prg: ");
        scanf("%d",&num);
    } 

    printf("El mayor numero ingreado es: %d",may);
    return 0;
}