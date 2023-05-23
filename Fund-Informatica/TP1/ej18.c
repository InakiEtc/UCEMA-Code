#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#define PI 3.141592

int main(){
    
    //area= pi x radio  al cuadrado
    //perimetro= 2 x pi x radio 
    float r;
    printf("Ingrese el radio del circulo: ");
    scanf("%f",&r);

    printf("El area del ciruclo es = %.2f \n",PI*(r*r));
    printf("El perimetro del ciruclo es = %.2f",2*PI*r);


    return 0;

}
