#include <stdio.h>
#include <stdlib.h>

int main(){

    float l;
    printf("ingrese el valor del lado del cuadrado: ");
    scanf("%f",&l);

    printf("El area del cuadrado es %f \n",l*l);
    printf("El perimetro del cuadrado es %f",4*l);

    return 0;

}
