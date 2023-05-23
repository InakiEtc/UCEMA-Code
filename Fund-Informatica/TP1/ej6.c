#include <stdio.h>
#include <stdlib.h>

int main(){

    int a1,a2;
    printf("Ingrese su anio de nacimiento: ");
    scanf("%d",&a1);
    printf("Ingrese el anio actual: ");
    scanf("%d",&a2);
 
    printf("Su edad es: %d",a2-a1);

    return 0;
}