#include <stdio.h>
#include <stdlib.h>

int main(){

    int a,b,aux;
    printf("Ingrese un numero entero: ");
    scanf("%d",&a);
    printf("Ingrese otro numero entero: ");
    scanf("%d",&b);
    while (b==a){
        printf("Los numeros no pueden ser iguales, ingrese otro numero entero: ");
        scanf("%d",&b);
    }
    printf("A = %d \n",a);
    printf("B = %d \n",b);
    aux=b;
    b=a;
    a=aux;
    printf("A = %d \n",a);
    printf("B = %d \n",b);


    return 0;
}