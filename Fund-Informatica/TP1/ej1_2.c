#include <stdio.h>
#include <stdlib.h>

int main(){

    int n1,n2;
    printf("Ingrese un numero entero: ");
    scanf("%d",&n1);
    printf("Ingrese un otro numero entero: ");
    scanf("%d",&n2);

    printf("La suma de los numeros es igual a: %d \n",n1+n2);
    printf("La resta de los numeros es igual a: %d \n",n1-n2);
    printf("El producto de los numeros es igual a: %d \n",n1*n2);
    printf("La division de los numeros es igual a: %d \n",n1/n2);

    return 0;
}