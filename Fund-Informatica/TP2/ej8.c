#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){

    float n1,n2,n3;
    printf("Ingrese una numero: ");
    scanf("%f",&n1);
    printf("Ingrese una numero: ");
    scanf("%f",&n2);
    printf("Ingrese una numero: ");
    scanf("%f",&n3);

    if (n3==n1+n2){ 
        printf("El n3 es igual a la suma de n1+n2");
    }
    else{
        printf("El n3 no es igual a la suma de n1+n2");
    }

    return 0;

}