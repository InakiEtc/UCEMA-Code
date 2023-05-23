#include <stdio.h>
#include <stdlib.h>

int main(){

    
    float n1,n2;
    printf("Ingrese el primer numero: ");
    scanf("%f",&n1);
    printf("Ingrese el segundo numero: ");
    scanf("%f",&n2);

    if(n1==n2){
        printf("Los numeros son iguales: N1=N2=%.2f",n1);
    }
    else if(n1>n2){
        printf("N1=%.1f es mayor a N2=%.1f",n1,n2);
    }else{
        printf("N2=%.1f es mayor a N1=%.1f",n2,n1);
    }

    return 0;

}