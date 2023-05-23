#include <stdio.h>
#include <stdlib.h>

int main(){

    
    float num;

    printf("Ingrese un numero: ");
    scanf("%f",&num);
  
    if(num>100){
        printf("El numero es mayor a 100");
    }
    else{
        printf("El numero es menor o igual a 100");
    }

    return 0;

}