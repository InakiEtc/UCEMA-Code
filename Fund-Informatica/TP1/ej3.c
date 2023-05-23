#include <stdio.h>
#include <stdlib.h>

int main(){

    int n1,n2;
    printf("Ingrese el primer numero entero: ");
    scanf("%d",&n1);
    printf("Ingrese segundo numero entero: ");
    scanf("%d",&n2);

    printf("La division es igual a: %d \n",n1/n2);
    printf("El resto es igual a: %d \n",n1%n2);

    return 0;
}