#include <stdio.h>
#include <stdlib.h>

int main(){

    int num;
    printf("Ingrese la edad de un individuo, el 0 corta el prg: ");
    scanf("%d",&num);
    
    while (num!=0){
        if(num <= 99 && num >=1){
            if (num <= 12 && num >=1){
                printf("ES UN NINO \n");
            }
            else if(num <= 21 && num >=12){
                printf("ES ADOLESCENTE \n");
            }
            else if(num <= 69 && num >=21){
                printf("ES ADULTO \n");
            }
            else{
                printf("TERCERA EDAD \n");
            }
            
        }else{
            printf("Ingrese un numero entre 1 y 99 \n");
        }

        printf("Ingrese la edad de un individuo, el 0 corta el prg: ");
        scanf("%d",&num);
    } 

    return 0;
}