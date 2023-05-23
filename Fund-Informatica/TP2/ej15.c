#include <stdio.h>
#include <stdlib.h>

int main(){

    int num,prim;
    printf("Ingrese un numero: ");
    scanf("%d",&num);

    if(num>0){
        prim=1;
        for (int i = 2; i < num; i++){
            if((num % i) == 0){
                prim = 0;
                break;
            }
        }
        if (prim==1){
            printf("El num %d es primo",num);
        }
        else{
            printf("El num %d no es primo",num);
        }
    }
    else{
        printf("El numero debe ser mayor a 0...");
    }

    return 0;
}


